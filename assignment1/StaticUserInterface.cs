/**
 * Kyle Sherman
 * CIS 237 - Advanced C# Programming
 * 1/25/2017
**/

// standard imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    static class StaticUserInterface
    {
        // create a new integer called GetUserInput
        public static int GetUserInput()
        {
            PrintMenu(); // print the main menu

            string inputString = Console.ReadLine(); // get the user input

            // validate the input to make sure it is a valid option
            while (inputString != "1" && inputString != "2" && inputString != "3" && inputString != "4" &&
                inputString != "5" && inputString != string.Empty && inputString != null)
            {
                Console.Clear();
                Console.WriteLine("that is not a valid input!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                PrintMenu(); // redisplay the menu if the user entered invalid input
                inputString = Console.ReadLine();
            }
            Console.Clear();

            // try-catch statement to parse the string the user entered into an int and return it
            try
            {
                return Int32.Parse(inputString);                    // parse the input from the user
            }
            catch (Exception e)                                     // catch any exceptions thrown
            {
                Console.Clear();
                Console.WriteLine("Input cannot be empty and must be a number");
                Console.WriteLine("Please try again.");
                return 0;
            }
        }

        // menu method
        private static void PrintMenu()
        {
            Console.WriteLine("1) Load Wine List From CSV");
            Console.WriteLine("2) Display Wine List");
            Console.WriteLine("3) Search by ItemID");
            Console.WriteLine("4) Add New Wine to List");
            Console.WriteLine("5) Exit");
        }

        // prints the entire contents of the wine item array 
        // alloutput is passed over from the wineItemCollection class
        public static void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

    }
}
