//Author Dylan Oszust
//Calorie Calculator (Windows Forms)
//
//This class allows the user to set their calorie goals

using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CalorieCalculatorWindows
{
    public partial class GoalEntry : Form
    {
        int goalCal;
        String mode;
        

        public GoalEntry()
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

        //update goals
        private void btnEnter_Click(object sender, EventArgs e)
        {
            SqlConnection _con;
            SqlCommand _cmd;
            goalCal = Int32.Parse(txtGoal.Text);
            mode = pnlMode.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text; //checks the mode selection


            //update user data with mode, and goal selection
            _con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\College\Summer2018\C#\Project\CalorieCalculatorWPF\CalorieCalculatorWindows\CalorieCalculatorWindows\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            _con.Open();
            _cmd = new SqlCommand("UPDATE [User] SET Mode = @Mode , GoalCal = @Goal WHERE UserID=1", _con);
            _cmd.Parameters.AddWithValue("Mode", mode);
            _cmd.Parameters.AddWithValue("Goal", goalCal);
            _cmd.ExecuteNonQuery();

            _con.Close();

            //lets user know the update was made and returns user home
            MessageBox.Show("Goals Updated");
            CalorieCalculatorHomeScreen frmCalorieCalculatorHomeScreen = new CalorieCalculatorHomeScreen();
            frmCalorieCalculatorHomeScreen.Show();
            this.Close();

        }


        private void GoalEntry_Load(object sender, EventArgs e)
        {
                  
        }
    }
}
