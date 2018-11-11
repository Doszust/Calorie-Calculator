//Author Dylan Oszust
//Calorie Calculator (Console Application)
//
//This class takes input to create a suggesstion for the user, and displays the suggesstion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCalculatorWindows;

namespace CalorieCounterConsoleApp
{
    class SuggestionDialogue
    {
        Suggestion suggestion;
        int age;
        int weight;
        int height;
        int activitySelection;
        string activity;
        Char sex;

        public void suggesstionMenu()
        {
            bool valid = false;
            string input;
            MainMenu mainMenu = new MainMenu();
            Console.Out.WriteLine("-----Get A Suggesstion-----\n" +
                "Press 'X' to return to the Main Menu any time");

            Console.Out.WriteLine("To get a suggesstion, I need some information first!");

            Console.Out.Write("How Old Are You?: ");

            while (!valid)
            {
                
                try
                {
                    input = Console.ReadLine().ToUpper();

                    if (input == "X")
                    {
                        Console.Out.WriteLine("Returning to Main Menu");
                        Console.Out.WriteLine("Press Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        age = Convert.ToInt32(input);
                        valid = true;
                    }
                }
                catch (Exception)
                {
                    Console.Out.Write("\nThat is an invalid input, try again: \n");
                }
            }
            valid = false;

            Console.Out.Write("How Much Do You Weigh In Pounds?:");

            while (!valid)
            {
                try
                {
                    input = Console.ReadLine().ToUpper();

                    if (input == "X")
                    {
                        Console.Out.WriteLine("Returning to Main Menu");
                        Console.Out.WriteLine("Press Any Key To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        weight = Convert.ToInt32(input);
                        valid = true;
                    }
                }
                catch (Exception)
                {
                    Console.Out.Write("\nThat is an invalid input, try again: \n");
                }
            }
            valid = false;

            Console.Out.Write("How Tall Are You In Inches?:");

            while (!valid)
            {
                try
                {
                    input = Console.ReadLine().ToUpper();

                    if (input == "X")
                    {
                        Console.Out.WriteLine("Returning to Main Menu");
                        Console.Out.WriteLine("Press Any Key To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        height = Convert.ToInt32(input);
                        valid = true;
                    }
                }
                catch (Exception)
                {
                    Console.Out.Write("\nThat is an invalid input, try again: \n");
                }
            }
            valid = false;

            Console.Out.Write("Are You Male(M) Or Female(F)?:");
            while (!valid)
            {
                try
                {
                    input = Console.ReadLine().ToUpper();

                    if (input == "X")
                    {
                        Console.Out.WriteLine("Returning to Main Menu");
                        Console.Out.WriteLine("Press Any Key To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        sex = char.ToUpper(Convert.ToChar(input));
                        if (sex == 'M' || sex == 'F')
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
                    Console.Out.Write("\nThat is an invalid input, try again: \n");
                }
            }
            valid = false;

            Console.Out.Write("Finally, What Is Your Activity Level? \n" +
                "1: Sedentary \n" +
                "2: Light \n" +
                "3: Moderate \n" +
                "4: Vigorous \n\n");

            while (!valid)
            {
                try
                {
                    input = Console.ReadLine().ToUpper();

                    if (input == "X")
                    {
                        Console.Out.WriteLine("Returning to Main Menu");
                        Console.Out.WriteLine("Press Any Key To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.menu();
                    }
                    else
                    {
                        activitySelection = Convert.ToInt32(input);
                        if (activitySelection > 0 && activitySelection < 5)
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
                    Console.Out.Write("\nThat is an invalid input, try again: \n");
                }
            }

            switch (activitySelection)
            {
                case 1:
                    activity = "Sedentary";
                    break;
                case 2:
                    activity = "Light";
                    break;
                case 3:
                    activity = "Moderate";
                    break;
                case 4:
                    activity = "Vigorous";
                    break;
            }

            suggestion = new Suggestion(age, weight, height, sex, activity);

            makeSuggesstion();

            Console.WriteLine("\nPress Enter To Return To Main Menu...");
            Console.ReadLine();
            Console.Clear();
            mainMenu.menu();
        }

        private void makeSuggesstion()
        {
            int maintain = suggestion.getMaintenenceCalories();
            int gain = suggestion.getGainCalories();
            int lose = suggestion.Loss();

            Console.Out.WriteLine("-----SUGGESSTED CALORIE INTAKE-----");
            Console.Out.WriteLine($"To Maintain Weight: {maintain} Calories");
            Console.Out.WriteLine($"To Lose Weight:     {lose} Calories");
            Console.Out.WriteLine($"To Gain Weight:     {gain} Calories");

            
        }
    }
}
