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
    class WineItem
    {
        // ******************************** 
        //          Backing Fields         
        // ********************************
        private string _wineItemID;
        private string _wineItemDescription;
        private string _wineItemVolume;

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
        //          Constructors                  
        // ********************************
        
        // 3 parameter constructor, passes in the wineItemID, description, and volume
        public WineItem(string wineItemIDString, string wineItemDescriptionString, string wineItemVolumeString)
        {
            this._wineItemID = wineItemIDString;
            this._wineItemDescription = wineItemDescriptionString;
            this._wineItemVolume = wineItemVolumeString;
        }

        public WineItem() { } // Blank Constructor

        // ToString override method
        // this method makes the WineItem.ToString() 
        // display a concatinated string of the 3 vars
        // wineID, wineName, and wineVolume
        public override string ToString()
        {
            // the this keyword is used to reference 'this' class. 
            // it allows us to reference things that are declard at this class @ 'class level'
            return this._wineItemID + " " + this._wineItemVolume + " " + this._wineItemVolume;
        }
    }
}
