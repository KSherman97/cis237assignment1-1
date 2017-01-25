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
    class WineItemCollection
    {
        WineItem[] _wineItemArray = new WineItem[5000]; // creates a new array of type WineItem with 5000 indexes

        // ******************************** 
        //          Backing Fields         
        // ********************************
        private string _wineItemID;
        private string _wineItemDescription;
        private string _wineItemVolume;

        // ******************************** 
        //          Constructors                  
        // ********************************
        public WineItemCollection() { } // blank constructor

        // 3 parameter constructor that accepts the wineItemID, description, and volume
        public WineItemCollection(string wineItemIDString, string wineItemDescriptionString, string wineItemVolumeString)
        {
            wineItemIDString = _wineItemID;
            wineItemDescriptionString = _wineItemDescription;
            wineItemVolumeString = _wineItemVolume;
        }

        // ******************************** 
        //            Properties                             
        // ********************************
        public string WineItemIDString
        {
            get { return _wineItemID; }
            set { _wineItemID = value; }
        }

        public string WineItemDescriptionString
        {
            get { return _wineItemDescription; }
            set { _wineItemDescription = value; }
        }

        public string WineItemVolumeString
        {
            get { return _wineItemVolume; }
            set { _wineItemVolume = value; }
        }

        // ******************************** 
        //            Methods                             
        // ********************************
        // this method is called to add a new wineItem to the array
        public void addWineItem(int index, string wineItemID, string wineItemDescription, string wineItemVolume)
        {
            _wineItemArray[index] = new WineItem(wineItemID, wineItemDescription, wineItemVolume); // add a new wineItem object to the array 
                                                                                                   // at the passed in index
        }

        // this method is used to output the entire array contents
        // utilizes a foreach loop to continue until a null is found
        public void outputWineItemArray()
        {
            string results = string.Empty;
            foreach (WineItem wine in _wineItemArray)                   // foreach(Employee(Type;like int) employee(pointer to Employee class) in employees(array))
            {
                if (wine != null)                                   // run a check to make sure the spot in the array is not empty
                {
                    // uses pads to make the output look neater and easier to read
                    results += "ID: " + wine.WineItemIDString.PadRight(6) + " Description: " + wine.WineItemDescriptionString.PadRight(65) + " Volume: " + wine.WineItemVolumeString + Environment.NewLine;
                }
            }
            StaticUserInterface.PrintAllOutput(results); // call the printAllOutput method from the UI class and pass through the results
        }

        // this method is used to search for a specific value that is passed in
        public string searchWineItem(string searchValue)
        {
            bool found = false;                                         // create a new "found" boolean and set it to false
            string results = string.Empty;
            int index = 0;                                              // index used for the loop

            foreach (WineItem wine in _wineItemArray)                   // foreach(Employee(Type;like int) employee(pointer to Employee class) in employees(array))
            {
                while (!found && index <= _wineItemArray.Length - 1)    // while the item hasn't been found and the end of the array hasn't been reached
                {
                    if (wine != null)                                   // run a check to make sure the spot in the array is not empty
                    {
                        if (wine.WineItemIDString == searchValue)           // if a match has been found
                        {
                            found = true;                               // set the found bool to true
                            // concatinated string of the resulting data
                            results = "Wine found!" + Environment.NewLine + "Wine ID: " + wine.WineItemIDString + Environment.NewLine + "Wine Description: " + wine.WineItemDescriptionString + Environment.NewLine + "Wine Volume: " + wine.WineItemVolumeString + Environment.NewLine;
                        }
                        else                                            // if a match has not been found the break the loop
                        {
                            results = "Item could not be found.";
                            break;
                        }
                    }
                    else                                                // if the next line is a null then break the loop
                    {
                        results = "Item could not be found.";
                        break;
                    }
                }
            }
            return results;                                             // return the string determined by the logic above
        }

        // this is the method called when a user wants to add an item by hand
        public void userAddItem(string wineID, string wineName, string wineVolume)
        {
            bool added = false;                                         // new bool 'added'
            string results = string.Empty;
            int index = 0;                                              // int used for the loop

            foreach (WineItem wine in _wineItemArray)                   // foreach(wineItem(Type) wine(pointer to wineItem class) in wineItemCollection(array))
            {
                while (!added && index <= _wineItemArray.Length - 1)    // while the added bool is false and the array is not full
                {
                    if (wine == null)                                   // run a check to make sure the spot in the array empty (able to be added to)
                    {
                        addWineItem(index, wineID, wineName, wineVolume);   // call the addWineItem method
                        added = true;                                       // set added to true
                        Console.WriteLine("Item has been Added!");          // let the user know that everything was successful
                        break;
                    }
                    else
                    {
                        index++;                                        // increase the index if the item has not been added
                    }
                    break;
                }
            }
        }

        // output Array method
        // use to output all items from the array
        public string outputArray()
        {
            string allOutPut = "";                                      // create a new empty string
            foreach (WineItem wine in _wineItemArray)                   // foreach(wineItem(Type) wine(pointer to wineItem class) in wineItemCollection(array))
            {
                if (wine != null)                                       // run a check to make sure the spot in the array is not empty
                {
                    allOutPut += wine.ToString() + Environment.NewLine; // print the employee
                }
            }
            return allOutPut;                                           // return the result of the logic above
        }

    }
}
