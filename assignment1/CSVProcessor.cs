/**
 * Kyle Sherman
 * CIS 237 - Advanced C# Programming
 * 1/25/2017
**/

// standard imports
// had to add an additional import System.IO
// to allow us to do file input and output
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
     class CSVProcessor
    {
        WineItemCollection addWineItem = new WineItemCollection(); // instantiates the wineItemCollection class


        // CSV Reader
        // dependency injection: https://msdn.microsoft.com/en-us/library/hh323705(v=vs.100).aspx
        // This method does handles the reading of the CSV File
        // both the path to the CSV and a new wineItemCollection object are passed in
        public  bool ImportCSVFile(string pathToCSVFile, WineItemCollection wineItems)
        {
            // declares a new variables for a StreamReader object. Not instantiating it yet
            StreamReader streamReader = null; // requiers: using System.IO; set default to null
            try                               // start a try catch since the path to the file could be incorrect, 
            {                                 // and thus throwing an exception
                // declare a string for the line
                string line;

                // instantiate the stream reader
                streamReader = new StreamReader(pathToCSVFile);

                int index = 0; // initialize a counter variable to 0 for the while loop

                // check if the file has reached a null yet
                // while there is a line to read, read it and put it in the line var
                while ((line = streamReader.ReadLine()) != null)
                {
                    // call the process line method and send over the read in line 
                    // the wineItemCollection array (which is passed by reference automatically)
                    // and the counter, which will be used as the index for the array.
                    // incrementing the counter after we send it in with the ++ operator
                    ProcessLine(line, wineItems, index++);
                }
                return true; // once the end of the file has been reached, return true
            }
            catch(Exception e)
            {
                // output the exception and the stacktrace for the exception
                Console.WriteLine("Error: " + e.ToString()
                    + Environment.NewLine + e.StackTrace);

                return false; // return false, stating that an exception has occured
            }
            finally // once the try / catch has completed, finish doing this stuff. 
            {       // Do it regardless if the try is successful or not

                // if there is a file to close then you need to close it before continuing on with the program
                if(streamReader != null)
                    streamReader.Close();
            }
        }

        // this method handles the processing of each individual line read into the CSV reader
        public  void ProcessLine(string line, WineItemCollection wineItems, int index)
        {
            var parts = line.Split(','); // declares a string array and assigns the split line to it.

            // assign the parts to local variables that mean something
            string wineItemID = parts[0];
            string wineItemDescription = parts[1];
            string wineItemVolume = parts[2];

            // Use the variables to instanciate a new wineItem and assign it to 
            // the spot in the wineItemCollection array indexed by the index that was passed in.
            wineItems.addWineItem(index, wineItemID, wineItemDescription, wineItemVolume);

            //wineItems[index] = new WineItem(wineItemID, wineItemDescription, wineItemVolume);
        }
    }
}
