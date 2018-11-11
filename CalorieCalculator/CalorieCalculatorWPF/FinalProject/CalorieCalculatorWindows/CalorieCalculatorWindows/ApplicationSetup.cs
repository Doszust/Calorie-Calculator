//Author Dylan Oszust
//Calorie Calculator (Windows Forms/Console App)
//
//This setsup the database for use.  This class is used by both
//the windows forms app, and the console app.
//If it is the first time the user is using the app, it will initialize the 
//history table with the date of first use.
//If the current date is not the same as the date of the last record in the history 
//table, this class will determine how many days have been missed, and update
//the table with the missed days, and set values to defult(0 for cal, and N for success).
//
//This class will also update the last recorded date with the calories consumed on that day, and
//rather it was a success or not, before refreshing the user table to be used for todays calories.

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculatorWindows
{
    public class ApplicationSetup
    {
        public void Setup(String source)
        {
            //setup database connection
            SqlConnection _con;
            SqlCommand _cmd;
            _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\Summer2018\C#\Project\CalorieCalculatorWPF\CalorieCalculatorWindows\CalorieCalculatorWindows\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();

            //check for empty table
            _cmd = new SqlCommand("SELECT COUNT(*) FROM History", _con);
            int rows = (Int32)_cmd.ExecuteScalar();

            if (rows == 0) //enters first row in history table(First Time App Use)
            {
                _cmd = new SqlCommand($"INSERT INTO History (Date) VALUES(GETDATE())", _con);
                _cmd.ExecuteNonQuery();
            }
            else //Returning User
            {
                //Get last date from table
                _cmd = new SqlCommand("SELECT TOP 1 Date FROM History ORDER BY Date DESC", _con);
                DateTime lastDate = DateTime.Parse(_cmd.ExecuteScalar().ToString());
                DateTime todaysDate = DateTime.Now.Date;

                //check if last date is the same as todays
                bool samedate = lastDate == todaysDate;

                //if its not the same day, catchup history, and start new day
                if (!samedate)
                {
                    historyCatchUp(_con, lastDate, todaysDate);
                    updateCaloriesHistory(_con, lastDate);
                    determineSuccess(_con, todaysDate, lastDate, source);
                    userNewDay(_con);
                }
            }

            //close connection
            _con.Close();
        }

        //catches up history from last use
        private bool historyCatchUp(SqlConnection _con, DateTime lastDate, DateTime todaysDate)
        {
            int daysPassed = (todaysDate - lastDate).Days;
            bool daysMissed = daysPassed > 1;

            for (int i = 0; i < daysPassed; i++)
            {
                SqlCommand _cmd;
                DateTime date = lastDate.AddDays(i + 1);
                _cmd = new SqlCommand($"INSERT INTO History (Date) VALUES (@date)", _con);
                _cmd.Parameters.AddWithValue("@date", date);
                _cmd.ExecuteNonQuery();
            }

            return daysMissed;
        }

        //resets daily calorie count to 0
        private void userNewDay(SqlConnection _con)
        {
            SqlCommand _cmd;
            _cmd = new SqlCommand("UPDATE [User] SET TodaysCal = 0", _con);
            _cmd.ExecuteNonQuery();
        }

        //will determine successful days and updates databases accordingly
        private void determineSuccess(SqlConnection _con, DateTime todaysDate, DateTime lastDate, String source)
        {
            SqlCommand _cmd;
            DateTime yesterday = todaysDate.AddDays(-1); //get yesterdays record
            bool success = false;

            //get Mode
            _cmd = new SqlCommand("SELECT Mode FROM [User]", _con);
            string mode = _cmd.ExecuteScalar().ToString();

            //get Calorie Goal
            _cmd = new SqlCommand("SELECT GoalCal FROM [User]", _con);
            int goal = Convert.ToInt32(_cmd.ExecuteScalar());

            //get Yesterdays Calories
            _cmd = new SqlCommand("SELECT Calories FROM History where Date = @yesterday", _con);
            _cmd.Parameters.AddWithValue("@yesterday", yesterday);
            int yesterdaysCalories = Convert.ToInt32(_cmd.ExecuteScalar());

            //Decide if yesterday was a success
            if (mode == "Lose" && yesterdaysCalories <= goal)
            {
                if (yesterdaysCalories >= 1000) //makes sure enough calories were tracked yesterday
                {
                    success = true;
                }
                else //displays a message explaining why it wasn't a successful day
                {
                    String unsuccessful = "Your Calories for Yesterday were less than 1000. " +
                            "\nEither you didn't track your calories, or you are eating too little." +
                            "\nUnfortunately yesterday will not count as a successful day,  Don't give up!";

                    if (source == "forms")
                    {
                        MessageBox.Show(unsuccessful);
                    }
                    else
                    {
                        Console.Out.Write(unsuccessful);
                    }
                }
            }
            else if (mode == "Gain" && yesterdaysCalories >= goal)
            {
                success = true;
            }
            else
            {
                String unsuccessful = "Unfortunately you didn't meet your calorie goal for the day yesterday." +
                        " Don't give up!";

                if (source == "forms")
                {
                    MessageBox.Show(unsuccessful);
                }else
                {
                    Console.Out.Write("unsuccessful");
                }
            }

            //if yesterday was a success
            if (success)
            {
                //set history success
                _cmd = new SqlCommand("UPDATE History SET Success = 'Y' where Date = @yesterday", _con);
                _cmd.Parameters.AddWithValue("@yesterday", yesterday);
                _cmd.ExecuteNonQuery();

                //increase successful days in a row by one
                _cmd = new SqlCommand("SELECT SuccessfulDays FROM [User]", _con);
                int successfulDays = Convert.ToInt32(_cmd.ExecuteScalar()) + 1;

                _cmd = new SqlCommand("UPDATE [User] SET SuccessfulDays = @successfulDays", _con);
                _cmd.Parameters.AddWithValue("@successfulDays", successfulDays);
                _cmd.ExecuteNonQuery();
            }
            else //resets successful days in a row
            {
                _cmd = new SqlCommand("UPDATE [User] SET SuccessfulDays = 0", _con);
                _cmd.ExecuteNonQuery();
            }

            //get last dates calories
            _cmd = new SqlCommand("SELECT Calories FROM History where Date = @lastDate", _con);
            _cmd.Parameters.AddWithValue("@lastDate", lastDate);
            int lastDatesCalories = Convert.ToInt32(_cmd.ExecuteScalar());

            if (mode == "Lose" && lastDatesCalories <= goal)
            {
                if (lastDatesCalories >= 1000) //makes sure enough calories were tracked during the last entry
                {
                    _cmd = new SqlCommand("UPDATE History SET Success = 'Y' where Date = @lastDate", _con);
                    _cmd.Parameters.AddWithValue("@lastDate", lastDate);
                    _cmd.ExecuteNonQuery();
                }
            }

        }

        private void updateCaloriesHistory(SqlConnection _con, DateTime lastDate)
        {
            SqlCommand _cmd; //get yesterdays record
            int calories;

            //get calories from user
            _cmd = new SqlCommand("SELECT TodaysCal from [User]", _con);
            calories = Convert.ToInt32(_cmd.ExecuteScalar());

            //save calories to history (sets calories to last date the app was used)
            _cmd = new SqlCommand("UPDATE History SET Calories = @calories where Date = @date", _con);
            _cmd.Parameters.AddWithValue("@calories", calories);
            _cmd.Parameters.AddWithValue("@date", lastDate);
            _cmd.ExecuteNonQuery();

        }
    }
}
