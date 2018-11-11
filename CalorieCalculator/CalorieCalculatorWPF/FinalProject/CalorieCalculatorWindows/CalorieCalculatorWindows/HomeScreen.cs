//Author Dylan Oszust
//Calorie Calculator (Windows Forms)
//
//This home screen will allow the user to navigate to various parts of the application

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculatorWindows
{
    public partial class CalorieCalculatorHomeScreen : Form
    {
        public CalorieCalculatorHomeScreen()
        {
            InitializeComponent();
        }

        //opens calculator
        private void btnCalculator_Click(object sender, EventArgs e)
        {
            DailyIntakeCalculator frmDailyIntakeCalculator = new DailyIntakeCalculator();
            frmDailyIntakeCalculator.Show();
            this.Hide();
        }

        //opens history
        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryScreen frmHistory = new HistoryScreen();
            frmHistory.Show();
        }

        //opens goals
        private void btnSetGoals_Click(object sender, EventArgs e)
        {
            GoalEntry frmGoalEntry = new GoalEntry();
            frmGoalEntry.Show();
            this.Hide();
        }

        //opens suggestions
        private void btnSuggestion_Click(object sender, EventArgs e)
        {
            CalorieIntakeSuggesstion frmCalorieIntakeSuggesstion = new CalorieIntakeSuggesstion();
            frmCalorieIntakeSuggesstion.Show();
            this.Hide();
        }

        private void CalorieCalculatorHomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
