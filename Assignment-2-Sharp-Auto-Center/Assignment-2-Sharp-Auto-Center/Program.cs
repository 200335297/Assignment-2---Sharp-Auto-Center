/*
 * App name :- SharpAutoForm
 * Author's name :- Gowtham Talluri
 * Student ID :- 200335297
 * App Creation Date :- 2017-02-12
 * APP description :- "This program calculates the amount due on a New or Used Vehicle"
*/
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

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize Splash form
            Program.splah = new SplashForm();
           
            Application.Run(Program.splah);
        }
    }
}
