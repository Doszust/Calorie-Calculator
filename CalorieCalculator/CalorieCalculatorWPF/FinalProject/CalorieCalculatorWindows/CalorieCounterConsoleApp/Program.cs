//Author Dylan Oszust
//Calorie Calculator (Console Application)
//
//Entry point for Console Application

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCalculatorWindows;

namespace CalorieCounterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.menu();
        }
    }
}
