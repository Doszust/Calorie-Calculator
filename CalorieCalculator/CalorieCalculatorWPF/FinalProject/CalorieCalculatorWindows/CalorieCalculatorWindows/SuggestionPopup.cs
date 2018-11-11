//Author Dylan Oszust
//Calorie Calculator (Windows Forms)
//
//This will display the caloric intake suggesstions

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
    public partial class SuggestionPopup : Form
    {
        Suggestion suggest; //sets suggesstion
        int maintain; //calories needed to maintain weight
        int lose; //calories needed to lose weight
        int gain; //calories needed to gain weight

        public SuggestionPopup(Suggestion suggest)
        {
            this.suggest = suggest;
            InitializeComponent();
            showSuggesstion();
        }

        //returns user to home screen
        private void btnOk_Click(object sender, EventArgs e)
        {
            CalorieCalculatorHomeScreen frmCalorieCalculatorHomeScreen = new CalorieCalculatorHomeScreen();
            frmCalorieCalculatorHomeScreen.Show();
            this.Close();
        }

        //shows user suggesstion based on inputs
        private void showSuggesstion()
        {
            maintain = suggest.getMaintenenceCalories();
            gain = suggest.getGainCalories();
            lose = suggest.Loss();

            lblMaintainResults.Text = maintain.ToString();
            lblGainResults.Text = gain.ToString();
            lblLoseResults.Text = lose.ToString();
        }
    }
}
