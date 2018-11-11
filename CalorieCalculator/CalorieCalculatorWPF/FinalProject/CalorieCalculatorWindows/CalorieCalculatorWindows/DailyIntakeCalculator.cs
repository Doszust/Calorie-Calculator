//Author Dylan Oszust
//Calorie Calculator (Windows Forms)
//
//This class will take the users input and update their data in the data base
//Every time an update is made, the information will change to reflect the update.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculatorWindows
{
    public partial class DailyIntakeCalculator : Form
    {
        int goalCal = 0;
        int todaysCal = 0;
        int successfulDays = 0;
        String mode = null;

        public DailyIntakeCalculator()
        {
            InitializeComponent();
        }

        //returns user home
        private void btnHome_Click(object sender, EventArgs e)
        {
            CalorieCalculatorHomeScreen frmCalorieCalculatorHomeScreen = new CalorieCalculatorHomeScreen();
            frmCalorieCalculatorHomeScreen.Show();
            this.Close();
        }

        //gets data on load
        private void DailyIntakeCalculator_Load(object sender, EventArgs e)
        {
            getUserData();
        }

        private void getUserData()
        {
            //Connect to DB
            SqlConnection _con;
            SqlCommand _cmd;
            _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\Summer2018\C#\Project\CalorieCalculatorWPF\CalorieCalculatorWindows\CalorieCalculatorWindows\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();
            
            //Get Users Mode
            _cmd = new SqlCommand("SELECT Mode FROM [User] WHERE UserID = 1", _con);
            mode = _cmd.ExecuteScalar().ToString();

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

            //Setup UI with proper info
            setupUI();
        }

        private void setupUI()
        {
            if(mode == "Lose")
            {
                lblCaloriesLeft.Text = "You May Still Eat:";
            }
            if(mode == "Gain")
            {
                lblCaloriesLeft.Text = "You Must Still Eat:";
            }

            lblCaloriesEatenResult.Text = todaysCal.ToString() + " Cal";
            lblCaloriesLeftResult.Text = (goalCal - todaysCal).ToString() + " Cal";
            lblSuccessfulDaysResult.Text = successfulDays.ToString();

        }

        //updates data with user input
        private void btnAddCalories_Click(object sender, EventArgs e)
        {
            int calEntry = Convert.ToInt32(txtAddCalories.Text);
            todaysCal = todaysCal + calEntry;

            //setup database connection
            SqlConnection _con;
            SqlCommand _cmd;
            _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\Summer2018\C#\Project\CalorieCalculatorWPF\CalorieCalculatorWindows\CalorieCalculatorWindows\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();

            //updates data
            _cmd = new SqlCommand($"UPDATE [User] SET TodaysCal={todaysCal}", _con);
            _cmd.ExecuteNonQuery();
            _con.Close();

            getUserData();//updates screen

            

        }

        private void btnSubtractCalories_Click(object sender, EventArgs e)
        {
            int calEntry = Convert.ToInt32(txtSubtractCalories.Text);
            todaysCal = todaysCal - calEntry;

            //Setup database connection
            SqlConnection _con;
            SqlCommand _cmd;
            _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\Summer2018\C#\Project\CalorieCalculatorWPF\CalorieCalculatorWindows\CalorieCalculatorWindows\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();

            //updates data
            _cmd = new SqlCommand($"UPDATE [User] SET TodaysCal={todaysCal}", _con);
            _cmd.ExecuteNonQuery();
            _con.Close();

            getUserData();//updates screen


        }
    }
}
