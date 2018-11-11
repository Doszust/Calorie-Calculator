//Author Dylan Oszust
//Calorie Calculator (Windows Forms)
//
//Entry point for the Windows Forms Application

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculatorWindows
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            String source = "forms";
            ApplicationSetup setup = new ApplicationSetup();
            setup.Setup(source);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalorieCalculatorHomeScreen());
        }
    }
}
