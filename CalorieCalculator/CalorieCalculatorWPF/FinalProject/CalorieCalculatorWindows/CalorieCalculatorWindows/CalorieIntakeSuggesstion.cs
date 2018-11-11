//Author Dylan Oszust
//Calorie Calculator (Windows Forms)
//
//This class takes in uder input and calculates suggessted calorie intakes.


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
    public partial class CalorieIntakeSuggesstion : Form
    {

        int age = 0;
        int height = 0;
        int weight = 0;
        String activity = null;
        public Suggestion suggest;
        SuggestionPopup popup;

        public CalorieIntakeSuggesstion()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            age = Int32.Parse(txtAge.Text);
            height = Int32.Parse(txtHeight.Text);
            weight = Int32.Parse(txtWeight.Text);
            activity = cmbActivityLvl.Text;
            Char sex = pnlSex.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text[0];



            suggest = new Suggestion(age, weight, height, sex, activity);
            popup = new SuggestionPopup(suggest);
            popup.Show();
            this.Close();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CalorieCalculatorHomeScreen frmCalorieCalculatorHomeScreen = new CalorieCalculatorHomeScreen();
            frmCalorieCalculatorHomeScreen.Show();
            this.Close();
        }
    }
}
