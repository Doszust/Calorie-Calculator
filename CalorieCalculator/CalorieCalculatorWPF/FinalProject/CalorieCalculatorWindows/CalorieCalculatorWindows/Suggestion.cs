//Author Dylan Oszust
//Calorie Calculator (Windows Forms/Console App)
//
//This will calculate the suggessted calories and create a suggesstion
//to be displayed in both the console app and the windows forms app.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculatorWindows
{
    public class Suggestion
    {
        private int age; //users age
        private int weight; //users weight
        private int height; //users height
        private int loss; //calories for weight loss
        private int gainCal; //calories for weight gain
        private int maintainCal; //calories for weight maitainence 
        private double BMR; //Base Metobalic Rate (used for calculations)
        private Char sex; //Users Sex
        private String activity; //Users Activity Level

        //sets values to users input
        public Suggestion(int age, int weight, int height, Char sex, String activity)
        {
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.activity = activity;
            this.sex = sex;
            makeSuggestion();
        }

        //makes suggesstion by calculating values
        private void makeSuggestion()
        {
            getBMR();
            maintainCal = calculateMaintainCalories();
            loss = maintainCal - 500; //calc loss cal
            gainCal = maintainCal + 500; //calc gain cal

        }

        //calculate users BMR from input
        private void getBMR()
        {
            if (sex == 'M')
            {
                BMR = 66.47 + (6.23 * weight) + (12.7 * height) - (6.8 * age);
            }
            else if (sex == 'F')
            {
                BMR = 665 + (4.35 * weight) + (4.7 * height) - (4.7 * age);
            }
        }


        //Uses BMR and activity level to calculate maitainence calories
        private int calculateMaintainCalories()
        {
            int cal = 0;
            switch (activity)
            {
                case "Sedentary":
                    cal = Convert.ToInt32(BMR * 1.2);
                    break;
                case "Light":
                    cal = Convert.ToInt32(BMR * 1.375);
                    break;
                case "Moderate":
                    cal = Convert.ToInt32(BMR * 1.55);
                    break;
                case "Vigorous":
                    cal = Convert.ToInt32(BMR * 1.9);
                    break;
            }
            return cal;
        }

        //returns maitenence cal
        public int getMaintenenceCalories()
        {
            return maintainCal;
        }
        
        //return loss
        public int Loss()
        {
            return loss;

            // _______________
            //|       |       |
            //|  |    | |     |
            //|  |    | |  |  |
            //|__|____|_|__|__|
            //|       |       |
            //|  |  | |  |    |
            //|  |  | | _|___ |
            //|_______|_______|
            //
        }

        //return gain gal
        public int getGainCalories()
        {
            return gainCal;
        }
    }
}
