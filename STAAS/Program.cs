
using FoodAppSTAAS.Lunch;
using STAAS.Chinonso.Pages;
using STAAS.Customization;
using STAAS.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAAS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPage());
        }
    }
}
