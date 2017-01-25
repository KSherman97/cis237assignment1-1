using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = Int16.MaxValue - 1;
            Console.SetWindowSize(120, 30);

            bool CSVFileLoaded = false;

            int userInput = StaticUserInterface.GetUserInput();

            WineItem wineItems = new WineItem();

            WineItemCollection wineItemArrayCollection = new WineItemCollection();

            while (userInput != 5)
            {
                if (userInput == 1)
                {
                    if(!CSVFileLoaded)
                    {
                        Console.Clear();

                        StaticCSVProcessor readFile = new StaticCSVProcessor();
                        readFile.ImportCSVFile("../../../datafiles/WineList.CSV", wineItemArrayCollection);

                        Console.WriteLine("File Read Successful.");
                        CSVFileLoaded = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("File can only be read 1 time");
                    }
                }

                if (userInput == 2)
                {
                    Console.Clear();

                    string allWineItemsOutput = wineItemArrayCollection.outputArray();

                    if (allWineItemsOutput != string.Empty)
                        wineItemArrayCollection.outputWineItemArray();
                    else
                        Console.WriteLine("There is no data to display. Try loading the file first.");
                     
                }

                if (userInput == 3)
                {
                    Console.Write("Enter an ID to search for a Wine Item: ");
                    string targetWineItem = Console.ReadLine();
                    Console.Clear();


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
