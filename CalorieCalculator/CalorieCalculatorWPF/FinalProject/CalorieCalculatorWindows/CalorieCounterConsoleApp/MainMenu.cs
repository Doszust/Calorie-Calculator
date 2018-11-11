//Author Dylan Oszust
//Calorie Calculator (Console Application)
//
//This class is the main menu, and allows the user to navigate
//to various parts of the application.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCalculatorWindows;

namespace CalorieCounterConsoleApp
{
    public class MainMenu
    {
        static int input;
        static SuggestionDialogue suggesstion;
        static GoalEntryDialogue goals;
        static CalculatorDialogue calculator;
        DisplayHistory history;

        public void menu()
        {
            //setup application
            ApplicationSetup setup = new ApplicationSetup();
            String source = "console"; //source value to pass to setup
            setup.Setup(source);

            //console app main menu
            Console.Out.Write("Welcome to the Calorie Counter \n" +
                "If it is your first time, you will need to set up goals before use \n" +
                "Please Make A Selection: \n" +
                "1: Get a Suggesstion \n" +
                "2: Set Goals \n" +
                "3: Use Calculator \n" +
                "4: View History \n\n");

            //get user input, if input is invalid, restate the menu
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Out.Write("You Must Enter A Number\n\n");
                menu();
            }

            //directs user to dialogue based on input
            if (input > 0 && input < 5)
            {
                switch (input)
                {
                    case 1:
                        suggesstion = new SuggestionDialogue();
                        Console.Clear();
                        suggesstion.suggesstionMenu();
                        break;
                    case 2:
                        goals = new GoalEntryDialogue();
                        Console.Clear();
                        goals.enterGoals();
                        break;
                    case 3:
                        calculator = new CalculatorDialogue();
                        Console.Clear();
                        calculator.start();
                        break;
                    case 4:
                        history = new DisplayHistory();
                        Console.Clear();
                        history.display();
                        break;
                }
            }
            else //invalid input, restates menu
            {
                Console.Out.Write($"{input} is not a valid selection.\n\n");
                menu();
            }

        }
    }
}
