/**
 * Kyle Sherman
 * CIS 237 - Advanced C# Programming
 * 1/25/2016
**/

// standard imports

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        // main method of the program class
        // all work is done in this method because 
        // classes are used to externalize processes 
        // into their respective function.
        static void Main(string[] args)
        {
            Console.BufferHeight = Int16.MaxValue - 1;  // resets the console bufferhieght to allow the entire file
                                                        // to be read into a single console window
            Console.SetWindowSize(120, 30);             // resizes the window to fit the special output formatting

            bool CSVFileLoaded = false;                 // boolean used to determine if the CSV file has been read or not

            int userInput = StaticUserInterface.GetUserInput(); // get the user input from the UI class;
                                                                // I opted to try a static class, rather than a normal one
                                                                // so there is no need to instantiate it

            WineItem wineItems = new WineItem();                 // instantiates the wineItem class

            WineItemCollection wineItemArrayCollection = new WineItemCollection(); // instantiates the wineItemCollection class

            while (userInput != 5)      // continue until 5(exit code) is entered as the menu value
            {
                if (userInput == 1)     // if the user enters 1 to read the file, do the required tasks
                {
                    if (!CSVFileLoaded)  // checks if the CSV file is loaded or not
                    {
                        Console.Clear();

                        StaticCSVProcessor readFile = new StaticCSVProcessor(); // instantiates the read CSVProcessor class
                        readFile.ImportCSVFile("../../../datafiles/WineList.CSV", wineItemArrayCollection); // calls the ReadCSV method in the CSV reader class

                        Console.WriteLine("File Read Successful.");             // let the user know that the file was read propperly
                        CSVFileLoaded = true;                                   // set the CSVLoaded bool to true
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("File can only be read 1 time");
                    }
                }

                if (userInput == 2)     // user mode 2 (output the list of wineitems)
                {
                    Console.Clear();

                    string allWineItemsOutput = wineItemArrayCollection.outputArray(); // assigns the allOutPut string to the returned value of the 
                                                                                     // WineItemCollection classes outPutArray method

                    if (allWineItemsOutput != string.Empty) // if the array isn't empty then go ahead and output it
                        wineItemArrayCollection.outputWineItemArray();  // calls the outputWineItemArray method in the wineitemcollection class
                    else
                        Console.WriteLine("There is no data to display. Try loading the file first.");
                     
                }

                if (userInput == 3)     // user mode 3 (search for a wineItem)
                {
                    Console.Write("Enter an ID to search for a Wine Item: ");
                    string targetWineItem = Console.ReadLine();         // gets the value to search for
                    Console.Clear();

                    // assign the results from the searchWineItem method inthe wineitemcollection class
                    string searchResults = wineItemArrayCollection.searchWineItem(targetWineItem);
                    Console.WriteLine(searchResults);
                }

                if (userInput == 4)                        // if the user enters 4 to add an item to the array, do the required tasks
                {
                    Console.Write("Enter the Wine ID to add: ");                // prompts the user for the ID to add
                    string wineID = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Enter the Wine Name to add: ");              // prompts the user for the name to add
                    string wineName = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Enter the Wine Volume to add: ");            // prompts the user for the volume to add
                    string wineVolume = Console.ReadLine();
                    Console.Clear();

                    // calls the WineItemCollection class's userAddItem method
                    // using the variables wineID, wineName, wineVolume strings passed from this class
                    // if statement prevents empty strings from being added to the array
                    if (wineID != String.Empty && wineName != String.Empty && wineVolume != String.Empty)
                        wineItemArrayCollection.userAddItem(wineID, wineName, wineVolume);
                    else
                        Console.Write("Sorry, you must enter first something in order to add it.");
                }

                // redisplay the main menu when an if statement is done doing its work
                Console.WriteLine("Press any Key to continue.");
                Console.ReadKey(); // wait for the user to press a key
                Console.Clear();
                userInput = StaticUserInterface.GetUserInput(); // prompt the user to enter some input again
            }
        }
    }
}
