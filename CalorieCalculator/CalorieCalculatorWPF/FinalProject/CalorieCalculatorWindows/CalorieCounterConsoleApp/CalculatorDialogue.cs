//Author Dylan Oszust
//Calorie Calculator (Console Application)
//
//This class will allow the user to add or subtract calories for the day

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounterConsoleApp
{
    class CalculatorDialogue
    {
        int todaysCal;
        int calLeft;
        int successfulDays;
        int goalCal;
        int calEntry;
        bool valid;
        string input;
        MainMenu mainMenu = new MainMenu();

        //starts calculator dialogue
        public void start()
        {
            valid = false;
            int selection = 0;
            
            retrieveUserInfo();
            Console.Out.WriteLine("-----Daily Intake Calculator-----");
            Console.Out.WriteLine("Press 'X' at any time to return to Main Menu");
            displayInfo();
            Console.Out.WriteLine($"Successful Days In A Row: {successfulDays}");


            

            while (!valid) //forces valid input
            {
                Console.Out.WriteLine("What Would You Like To Do?\n" +
                "1: Add Calories\n" +
                "2: Subtract Calories\n");

                try
                {
                    input = Console.ReadLine().ToUpper();

                    if (input == "X") //user is returning to main menu
                    {
                        Console.Out.WriteLine("Returning To Main Menu");
                        Console.Out.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        selection = Convert.ToInt32(input);
                        valid = true;
                    }
                }
                catch (Exception)
                {
                    Console.Out.WriteLine("Invalid Input");
                }
            }

            //add or subtract calories
            switch(selection)
            {
                case 1:
                    addCalories();
                    break;
                case 2:
                    subtractCalories();
                    break;
            }
        }

        //get user info from database
        private void retrieveUserInfo()
        {
            //Connect to DB
            SqlConnection _con;
            SqlCommand _cmd;
            _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\Summer2018\C#\Project\CalorieCalculatorWPF\CalorieCalculatorWindows\CalorieCalculatorWindows\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();

            //Get Users Goal
            _cmd = new SqlCommand("SELECT GoalCal FROM [User] WHERE UserID = 1", _con);
            goalCal = (Int32)_cmd.ExecuteScalar();

            //Get Todays Calories
            _cmd = new SqlCommand("SELECT TodaysCal FROM [USER] where UserID = 1", _con);
            todaysCal = (Int32)_cmd.ExecuteScalar();

            //get Successful Days
            _cmd = new SqlCommand("SELECT SuccessfulDays FROM [USER] where UserID = 1", _con);
            successfulDays = (Int32)_cmd.ExecuteScalar();
            _con.Close();

            calLeft = goalCal - todaysCal; //calculates calories left for today
        }

        //displays daily calorie info
        private void displayInfo()
        {
            Console.Out.WriteLine("\n Today's Information");
            Console.Out.WriteLine($"Calories Eaten: {todaysCal}");
            Console.Out.WriteLine($"Calories Left: {calLeft}");
        }

        //adds calories to users daily intake
        private void addCalories()
        {
            Console.Out.WriteLine("Adding Calories");
            Console.Out.Write("Enter Amount Of Calories Eaten: ");

            valid = false;
            while (!valid)
            {
                try
                {
                    input = Console.ReadLine().ToUpper();

                    if (input == "X") //user return to menu
                    {
                        Console.Out.WriteLine("No Goals Updated");
                        Console.Out.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        calEntry = Convert.ToInt32(input);
                        valid = true;
                    }
                }
                catch (Exception)
                {
                    Console.Out.WriteLine("Invalid Input");
                }
            }

            todaysCal = todaysCal + calEntry; //adds calories to total

            update(todaysCal);

        }

        //subtracts calories from total
        private void subtractCalories()
        {
            Console.Out.WriteLine("Subtracting Calories");
            Console.Out.Write("Enter Amount Of Calories Burned: ");

            valid = false;
            while (!valid)
            {
                try
                {
                    input = Console.ReadLine().ToUpper();

                    if (input == "X")
                    {
                        Console.Out.WriteLine("Returning To Main Menu");
                        Console.Out.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        calEntry = Convert.ToInt32(input);
                        valid = true;
                    }
                }
                catch (Exception)
                {
                    Console.Out.WriteLine("Invalid Input");
                }
            }

            todaysCal = todaysCal - calEntry;

            update(todaysCal);
        }

        //update database
        private void update(int todaysCal)
        {
            //setup database connection
            SqlConnection _con;
            SqlCommand _cmd;
            _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\Summer2018\C#\Project\CalorieCalculatorWPF\CalorieCalculatorWindows\CalorieCalculatorWindows\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();

            //updates data
            _cmd = new SqlCommand($"UPDATE [User] SET TodaysCal={todaysCal}", _con);
            _cmd.ExecuteNonQuery();
            _con.Close();

            retrieveUserInfo();
            Console.Clear();
            start();
        }
    }
}
