using DPUruNet;
using FoodAppSTAAS.Lunch;
using STAAS;
using STAAS.Fingerprint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UareUSampleCSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace fingerprint
{
    public partial class FingerVerify : Form
    {
        STAAS_dbEntities db = new STAAS_dbEntities(); 
        public FingerVerify()
        {
            InitializeComponent();
        }
        private Reader currentReader;
        bool scanner = false;
        string signOutTime;
        string requestType;
        string username;
        string lateReason;
        public void SetLateReason(string text)
        {
            lateReason = text;
        }
        public Reader CurrentReader
        {
            get { return currentReader; }
            set
            {
                currentReader = value;
                SendMessage(Action.UpdateReaderState, value);
            }
        }
        private ReaderCollection _readers;
        private void LoadScanners()
        {
            cboReaders.Text = string.Empty;
            cboReaders.Items.Clear();
            cboReaders.SelectedIndex = -1;

            try
            {
                _readers = ReaderCollection.GetReaders();

                foreach (Reader Reader in _readers)
                {
                    cboReaders.Items.Add(Reader.Description.Name);
                }

                if (cboReaders.Items.Count > 0)
                {
                    cboReaders.SelectedIndex = 0;
                    scanner = true;
                }
                else
                {
                    scanner = false;
                }
            }
            catch (Exception ex)
            {
                //message box:
                String text = ex.Message;
                text += "\r\n\r\nPlease check if DigitalPersona service has been started";
                String caption = "Cannot access readers";
                MessageBox.Show(text, caption);
            }
        }
        private const int PROBABILITY_ONE = 0x7fffffff;
        private Fmd firstFinger;
        int count = 0;
        DataResult<Fmd> resultEnrollment;
        List<Fmd> preenrollmentFmds;
        /// <summary>
        /// Open a device and check result for errors.
        /// </summary>
        /// <returns>Returns true if successful; false if unsuccessful</returns>
        public bool OpenReader()
        {
            using (Tracer tracer = new Tracer("Form_Main::OpenReader"))
            {
                reset = false;
                Constants.ResultCode result = Constants.ResultCode.DP_DEVICE_FAILURE;

                // Open reader
                if (scanner)
                {
                    result = currentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);
                }else
                {
                    reset = true;
                    return false;
                }

                if (result != Constants.ResultCode.DP_SUCCESS)
                {
                    MessageBox.Show("Error:  " + result);
                    reset = true;
                    return false;
                }

                return true;
            }
        }

        /// <summary>
        /// Check quality of the resulting capture.
        /// </summary>
        public bool CheckCaptureResult(CaptureResult captureResult)
        {
            using (Tracer tracer = new Tracer("Form_Main::CheckCaptureResult"))
            {
                if (captureResult.Data == null || captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                    {
                        reset = true;
                        throw new Exception(captureResult.ResultCode.ToString());
                    }

                    // Send message if quality shows fake finger
                    if ((captureResult.Quality != Constants.CaptureQuality.DP_QUALITY_CANCELED))
                    {
                        throw new Exception("Quality - " + captureResult.Quality);
                    }
                    return false;
                }

                return true;
            }
        }
        private ReaderSelection _readerSelection;
        /// <summary>
        /// Hookup capture handler and start capture.
        /// </summary>
        /// <param name="OnCaptured">Delegate to hookup as handler of the On_Captured event</param>
        /// <returns>Returns true if successful; false if unsuccessful</returns>
        public bool StartCaptureAsync(Reader.CaptureCallback OnCaptured)
        {
            using (Tracer tracer = new Tracer("Form_Main::StartCaptureAsync"))
            {
                // Activate capture handler
                if (scanner)
                {
                    currentReader.On_Captured += new Reader.CaptureCallback(OnCaptured);

                    // Call capture
                    if (!CaptureFingerAsync())
                    {
                        return false;
                    }
                   
                }
                return true;
            }
        }
        /// <summary>
        /// Check the device status before starting capture.
        /// </summary>
        /// <returns></returns>
        public void GetStatus()
        {
            using (Tracer tracer = new Tracer("Form_Main::GetStatus"))
            {
                Constants.ResultCode result = currentReader.GetStatus();

                if ((result != Constants.ResultCode.DP_SUCCESS))
                {
                    reset = true;
                    throw new Exception("" + result);
                }

                if ((currentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_BUSY))
                {
                    Thread.Sleep(50);
                }
                else if ((currentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_NEED_CALIBRATION))
                {
                    currentReader.Calibrate();
                }
                else if ((currentReader.Status.Status != Constants.ReaderStatuses.DP_STATUS_READY))
                {
                    throw new Exception("Reader Status - " + currentReader.Status.Status);
                }
            }
        }
        /// <summary>
        /// Function to capture a finger. Always get status first and calibrate or wait if necessary.  Always check status and capture errors.
        /// </summary>
        /// <param name="fid"></param>
        /// <returns></returns>
        public bool CaptureFingerAsync()
        {
            using (Tracer tracer = new Tracer("Form_Main::CaptureFingerAsync"))
            {
                try
                {
                    GetStatus();

                    Constants.ResultCode captureResult = currentReader.CaptureAsync(Constants.Formats.Fid.ANSI, Constants.CaptureProcessing.DP_IMG_PROC_DEFAULT, currentReader.Capabilities.Resolutions[0]);
                    if (captureResult != Constants.ResultCode.DP_SUCCESS)
                    {
                        reset = true;
                        throw new Exception("" + captureResult);
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:  " + ex.Message);
                    return false;
                }
            }
        }
        /// <summary>
        /// Create a bitmap from raw data in row/column format.
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Bitmap CreateBitmap(byte[] bytes, int width, int height)
        {
            byte[] rgbBytes = new byte[bytes.Length * 3];

            for (int i = 0; i <= bytes.Length - 1; i++)
            {
                rgbBytes[(i * 3)] = bytes[i];
                rgbBytes[(i * 3) + 1] = bytes[i];
                rgbBytes[(i * 3) + 2] = bytes[i];
            }
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            for (int i = 0; i <= bmp.Height - 1; i++)
            {
                IntPtr p = new IntPtr(data.Scan0.ToInt64() + data.Stride * i);
                System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * bmp.Width * 3, p, bmp.Width * 3);
            }

            bmp.UnlockBits(data);

            return bmp;
        }
        /// <summary>
        /// Handler for when a fingerprint is captured.
        /// </summary>
        /// <param name="captureResult">contains info and data on the fingerprint capture</param>
        public void OnCaptured(CaptureResult captureResult)
        {
            try
            {
                // Check capture quality and throw an error if bad.
                if (!CheckCaptureResult(captureResult)) return;

                // Create bitmap
                foreach (Fid.Fiv fiv in captureResult.Data.Views)
                {
                    SendMessage(Action.SendBitmap, CreateBitmap(fiv.RawImage, fiv.Width, fiv.Height));
                }

                //Verification Code
                try
                {
                    // Check capture quality and throw an error if bad.
                    if (!CheckCaptureResult(captureResult)) return;

                    SendMessage(Action.SendMessage, "Fingerprint captured.");

                    DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);
                    if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                    {
                        if (resultConversion.ResultCode != Constants.ResultCode.DP_TOO_SMALL_AREA)
                        {
                            Reset = true;
                        }
                        throw new Exception(resultConversion.ResultCode.ToString());
                    }

                    firstFinger = resultConversion.Data;
                 
                    var fingerprintsData = from data in db.Fingerprints select data;
                    foreach (var fingerprint in fingerprintsData)
                    {
                        Fmd val = Fmd.DeserializeXml(fingerprint.Template);
                        CompareResult compare = Comparison.Compare(firstFinger, 0, val, 0);
                        if (compare.ResultCode != Constants.ResultCode.DP_SUCCESS)
                        {
                            Reset = true;
                            throw new Exception(compare.ResultCode.ToString());
                        }
                        if (Convert.ToDouble(compare.Score.ToString()) == 0)
                        {
                            username = fingerprint.Name;
                            //userUniqueId = fingerprint.UniqueId;
                            var myDate = DateTime.Now;
                            var dateString = myDate.Date.ToShortDateString();
                            var userAttendance = from data in db.Attendances where data.Email == fingerprint.Email && data.Date == dateString select data.TimeIn;


                            if (userAttendance.Count() == 0)
                            {                             
                                if(lateReason != "")
                                {
                                    SetLateReason();
                                }
                                SetRequest("signIn");
                                SetName(fingerprint.Name);
                                SetDepartment(fingerprint.Department);
                                SetGender(fingerprint.Gender);
                                SetEmail(fingerprint.Email);
                                SetDate();
                                count++;
                                break;
                            }
                            else
                            {
                                SetRequest("signOut");
                                SetEmail(fingerprint.Email);
                                var dateAndTime = DateTime.Now;
                                string date = dateAndTime.Date.ToShortDateString();
                                signOutTime = dateAndTime.ToString("HH:mm:ss");
                                var user = from data in db.Attendances where data.Email == fingerprint.Email && data.Date == date  select data;
                                foreach(var item in user)
                                {
                                    item.TimeOut = signOutTime;
                                }
                                break;
                            }
                        }
                    }

                    Int32 r = db.SaveChanges();
                    if (r > 0)
                    {
                        if(requestType == "signIn") {
                            BookLunch form = new BookLunch();
                            form.SetName(username);
                            form.SetEmail(emailTextBox.Text);
                            form.SetTime(timeInTextBox.Text);
                            CurrentReader.Dispose();
                            CloseForm();
                            form.ShowDialog();
                        }
                        
                        if(requestType == "signOut") {
                            SuccessSignIn form = new SuccessSignIn();
                            form.SetName(username);
                            form.SetEmail(emailTextBox.Text);
                            form.SetRequest("signOut");
                            form.SetTime(signOutTime);
                            CurrentReader.Dispose();
                            CloseForm();
                            form.ShowDialog();
                        }                    
                    }
                    else
                    {
                        MessageBox.Show("Couldn't verify Try again");
                    }
                }
                catch (Exception ex)
                {
                    // Send error message, then close form
                    SendMessage(Action.SendMessage, "Error:  " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Send error message, then close form
                SendMessage(Action.SendMessage, "Error:  " + ex.Message);
            }
        }
        /// <summary>
        /// Holds fmds enrolled by the enrollment GUI.
        /// </summary>
        public Dictionary<int, Fmd> Fmds
        {
            get { return fmds; }
            set { fmds = value; }
        }
        private Dictionary<int, Fmd> fmds = new Dictionary<int, Fmd>();

        /// <summary>
        /// Reset the UI causing the user to reselect a reader.
        /// </summary>
        public bool Reset
        {
            get { return reset; }
            set { reset = value; }
        }
        private bool reset;


        private enum Action
        {
            UpdateReaderState,
            SendBitmap,
            SendMessage
        }
        private delegate void SendMessageCallback(Action state, object payload);
        private void SendMessage(Action action, object payload)
        {
            try
            {
                if (this.pbFingerprint.InvokeRequired)
                {
                    SendMessageCallback d = new SendMessageCallback(SendMessage);
                    this.Invoke(d, new object[] { action, payload });
                }
                else
                {
                    switch (action)
                    {
                        case Action.SendMessage:
                            MessageBox.Show((string)payload);
                            break;
                        case Action.SendBitmap:
                            pbFingerprint.Image = (Bitmap)payload;
                            pbFingerprint.Refresh();
                            break;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
      

        private void FingerVerify_Load(object sender, EventArgs e)
        {
            LoadScanners();
            db.Fingerprints.Load();
            db.Attendances.Load();

            this.attendanceBindingSource.DataSource = db.Attendances.Local.ToBindingList();
            firstFinger = null;
            resultEnrollment = null;
            preenrollmentFmds = new List<Fmd>();
            pbFingerprint.Image = null;
            if (CurrentReader != null)
            {
                CurrentReader.Dispose();
                CurrentReader = null;
            }
            CurrentReader = _readers[cboReaders.SelectedIndex];
            if (!OpenReader())
            {
                //MessageBox.Show("Blah blah blah");
            }

            if (!StartCaptureAsync(this.OnCaptured))
            {
                //this.Close();
            }
            this.attendanceBindingSource.AddNew();          
        }

        delegate void SetNameCallback(string text);
        delegate void CloseFormCallBack();
        delegate void SetDepartmentCallback(string text);
        delegate void SetGenderCallback(string text);
        delegate void SetEmailCallback(string text);
        delegate void SetDateCallback();
        delegate void SetLateCallback();
        delegate void SetRequestCallback(string text);

        private void SetName(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.staffTextBox.InvokeRequired)
            {
                SetNameCallback d = new SetNameCallback(SetName);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.staffTextBox.Text = text;
            }
        }

        private void SetDepartment(string text)
        {
            if (this.InvokeRequired)
            {
                SetDepartmentCallback d = new SetDepartmentCallback(SetDepartment);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.departmentTextBox.Text = text; 
            }
        }

        private void SetGender(string text)
        {
            if (this.InvokeRequired)
            {
                SetGenderCallback d = new SetGenderCallback(SetGender);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.genderTextBox.Text = text;
            }
        }

        private void SetEmail(string text)
        {
            if (this.InvokeRequired)
            {
                SetEmailCallback d = new SetEmailCallback(SetEmail);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.emailTextBox.Text = text;
            }
        }

        private void SetRequest(string text)
        {
            if (this.InvokeRequired)
            {
                SetRequestCallback d = new SetRequestCallback(SetRequest);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                requestType = text;
            }
        }

        private void SetDate()
        {
            if (this.InvokeRequired)
            {
                SetDateCallback d = new SetDateCallback(SetDate);
                this.Invoke(d, new object[] {});
            }
            else
            {
                var dateAndTime = DateTime.Now;
                this.timeInTextBox.Text = dateAndTime.ToString("HH:mm:ss");
                this.dateTextBox.Text = dateAndTime.Date.ToShortDateString();
                this.attendanceBindingSource.EndEdit();
            }
        }

        private void SetLateReason()
        {
            if (this.InvokeRequired)
            {
                SetLateCallback d = new SetLateCallback(SetLateReason);
                this.Invoke(d);
            }
            else
            {
                latenessReasonTextBox.Text = lateReason;
            }
        }
        private void CloseForm()
        {
            if (this.InvokeRequired)
            {
                CloseFormCallBack d = new CloseFormCallBack(CloseForm);
                this.Invoke(d);
            }
            else
            {
                db.Dispose();
                this.Close();
            }
        }

        private void FingerVerify_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CurrentReader != null)
            {
                CurrentReader.Dispose();
                CurrentReader = null;
            }
        }
    }
}
