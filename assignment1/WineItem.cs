using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {

        private string _wineItemID;
        private string _wineItemDescription;
        private string _wineItemVolume;

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

        public WineItem(string wineItemIDString, string wineItemDescriptionString, string wineItemVolumeString)
        {
            this._wineItemID = wineItemIDString;
            this._wineItemDescription = wineItemDescriptionString;
            this._wineItemVolume = wineItemVolumeString;
        }

        public WineItem() { }

        public override string ToString()
        {
            return this._wineItemID + " " + this._wineItemVolume + " " + this._wineItemVolume;
        }
    }
}
