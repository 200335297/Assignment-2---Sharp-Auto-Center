using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Sharp_Auto_Center
{
    public static class Program
    {
        //declared static form - Application global
        public static SplashForm splah;

        public static sharpAutoForm sharp;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize Splash form and sharpform
            Program.splah = new SplashForm();
            Program.sharp = new sharpAutoForm();
            Application.Run(Program.splah);
        }
    }
}
