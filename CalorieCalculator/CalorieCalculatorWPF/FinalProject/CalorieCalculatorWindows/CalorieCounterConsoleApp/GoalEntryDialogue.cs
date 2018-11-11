//Author Dylan Oszust
//Calorie Calculator (Console Application)
//
//This class allows the user to create and update goals for themselves.

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounterConsoleApp
{
    class GoalEntryDialogue
    {
        MainMenu mainMenu = new MainMenu();

        //recieves user input for goals
        public void enterGoals()
        {
            Program main = new Program();
            int goalCal = 0;
            int modeSelect = 0;
            String input;
            bool valid = false; //used to force valid user entry
            Console.Out.WriteLine("-----Enter Goals-----\n" +
                "Press 'X' to return to the Main Menu at any time");

            //get goal calorie amount
            while (!valid)
            {
                Console.Out.Write("Enter Goal Calorie Amount: ");

                try
                {
                    input = Console.ReadLine().ToUpper();  
                    
                    if (input == "X")
                    {
                        Console.Out.WriteLine("No Goals Updated");
                        Console.Out.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        goalCal = Convert.ToInt32(input);
                        valid = true;
                    }
                }
                catch (Exception)
                {
                    Console.Out.WriteLine("Invalid Input: Enter A Number");
                }
            }


            //get mode
            valid = false;

            while (!valid)
            {
                Console.Out.WriteLine("\nSelect Mode \n" +
                    "1: Gain Weight \n" +
                    "2: Lose Weight\n");

                try
                {
                    input = Console.ReadLine().ToUpper();

                    if (input == "X")
                    {
                        Console.Out.WriteLine("No Goals Updated");
                        Console.Out.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        modeSelect = Convert.ToInt32(input);

                        if (modeSelect == 1 || modeSelect == 2)
                        {
                            valid = true;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                catch (Exception)
                {
                    Console.Out.WriteLine("Invalid Input");
                }
            }

            saveGoals(modeSelect, goalCal);
            Console.WriteLine("\nPress Enter To Return To Main Menu...");
            Console.ReadLine();
            Console.Clear();
            mainMenu.menu();            
        }

        //saves user input goals
        private void saveGoals(int modeInput, int goal)
        {
            SqlConnection _con;
            SqlCommand _cmd;
            String mode;

            if(modeInput == 1)
            {
                mode = "Gain";
            }
            else
            {
                mode = "Lose";
            }

            _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\Summer2018\C#\Project\CalorieCalculatorWPF\CalorieCalculatorWindows\CalorieCalculatorWindows\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();
            _cmd = new SqlCommand("UPDATE [User] SET Mode = @Mode , GoalCal = @Goal WHERE UserID=1", _con);
            _cmd.Parameters.AddWithValue("Mode", mode);
            _cmd.Parameters.AddWithValue("Goal", goal);
            _cmd.ExecuteNonQuery();
            _con.Close();

            Console.Out.WriteLine("\nGoals Updated");
        }
    }
}
