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
        WineItemCollection addWineItem = new WineItemCollection();

        public  bool ImportCSVFile(string pathToCSVFile, WineItemCollection wineItems)
        {
            StreamReader streamReader = null;
            try
            {
                // declare a string for the line
                string line;

                // instantiate the stream reader
                streamReader = new StreamReader(pathToCSVFile);

                int index = 0;
                while ((line = streamReader.ReadLine()) != null)
                {
                    //process the line
                    ProcessLine(line, wineItems, index++);
                }
                return true;
            }
            catch(Exception e)
            {
                // output the exception and the stacktrace for the exception
                Console.WriteLine("Error: " + e.ToString()
                    + Environment.NewLine + e.StackTrace);

                return false;
            }
            finally
            {
                if(streamReader != null)
                    streamReader.Close();
            }
        }

        public  void ProcessLine(string line, WineItemCollection wineItems, int index)
        {
            var parts = line.Split(',');

            string wineItemID = parts[0];
            string wineItemDescription = parts[1];
            string wineItemVolume = parts[2];

            wineItems.addWineItem(index, wineItemID, wineItemDescription, wineItemVolume);

            //wineItems[index] = new WineItem(wineItemID, wineItemDescription, wineItemVolume);
        }
    }
}
