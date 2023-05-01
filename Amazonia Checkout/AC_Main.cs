using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace Amazonia_Checkout
{
    internal static class AC_Main
    {
        public static string ClientId = ConfigurationManager.AppSettings["clientID"];
        public static string Tenant = ConfigurationManager.AppSettings["tenantID"];
        public static MainForm main;
        public static bool OpenApp = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                while (OpenApp)
                {
                    main = new MainForm();
                    Application.Run(main);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }


}
