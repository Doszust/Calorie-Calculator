//Author Dylan Oszust
//Calorie Calculator (Console Application)
//
//This class will get the history data from the History table
//and display it in a formatted display.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CalorieCounterConsoleApp
{
    class DisplayHistory
    {
        //displays history
        public void display()
        {
            SqlConnection _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\Summer2018\C#\Project\CalorieCalculatorWPF\CalorieCalculatorWindows\CalorieCalculatorWindows\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand _com;
            DateTime firstDate;
            DateTime date;
            MainMenu mainMenu = new MainMenu();

            int cal;
            String success;
            _con.Open();

            //counts records in table
            _com = new SqlCommand("SELECT COUNT(*) FROM History", _con);
            int records = Convert.ToInt32(_com.ExecuteScalar());

            //gets first date in the record
            _com = new SqlCommand("SELECT TOP 1 Date FROM History", _con);
            firstDate = Convert.ToDateTime(_com.ExecuteScalar().ToString());

            date = firstDate;

            //write header
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Date       |  Calories  |  Success");
            Console.WriteLine("----------------------------------");
            

            //for each record in the table
            for (int i=  0; i < records; i++)
            {
                //get calories
                _com = new SqlCommand("SELECT Calories FROM History where Date = @date", _con);
                _com.Parameters.AddWithValue("@date", date);
                cal = Convert.ToInt32(_com.ExecuteScalar());

                //get success
                _com = new SqlCommand("SELECT Success FROM History where Date = @date", _con);
                _com.Parameters.AddWithValue("@date", date);
                success = _com.ExecuteScalar().ToString();

                //print info formatted
                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,8}",
                    date.ToShortDateString(), cal, success));

                //move to next date
                date = date.AddDays(1);
            }
            Console.WriteLine("----------------------------------");

            _con.Close();

            Console.WriteLine("\nPress Enter To Return To Main Menu");
            Console.ReadLine();
            Console.Clear();
            mainMenu.menu();

        }
    }
}
