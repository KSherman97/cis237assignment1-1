using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        WineItem[] _wineItemArray = new WineItem[5000];

        private string _wineItemID;
        private string _wineItemDescription;
        private string _wineItemVolume;

        public WineItemCollection() { }

        public WineItemCollection(string wineItemIDString, string wineItemDescriptionString, string wineItemVolumeString)
        {
            wineItemIDString = _wineItemID;
            wineItemDescriptionString = _wineItemDescription;
            wineItemVolumeString = _wineItemVolume;
        }

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


        public void addWineItem(int index, string wineItemID, string wineItemDescription, string wineItemVolume)
        {
            _wineItemArray[index] = new WineItem(wineItemID, wineItemDescription, wineItemVolume);
        }

        public void outputWineItemArray()
        {
            string results = string.Empty;
            foreach (WineItem wine in _wineItemArray)                   // foreach(Employee(Type;like int) employee(pointer to Employee class) in employees(array))
            {
                if (wine != null)                                   // run a check to make sure the spot in the array is not empty
                {
                    results += "ID: " + wine.WineItemIDString.PadRight(6) + " Description: " + wine.WineItemDescriptionString.PadRight(60) + "  Volume: " + wine.WineItemVolumeString + Environment.NewLine;
                }
            }
            StaticUserInterface.PrintAllOutput(results);
        }

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
