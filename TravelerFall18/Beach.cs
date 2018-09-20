using System.Collections.Generic;

namespace TravelerFall18
{
    public class Beach
    {
        //Fields
        private string eyeColor;
        private double shoeSize;
        private List<string> names = new List<string>();

        //Properties
        public string EyeColor
        {
            get { return this.eyeColor; }
            set { this.eyeColor = value; }
        }
        public double ShoeSize
        {
            get { return this.shoeSize; }
            set { this.shoeSize = value; }
        }
        public List<string> Names
        {
            get { return this.names; }
            set { this.names = value; }
        }
        
        //Constructors
        public Beach()
        {

        }
        public Beach(string val_eyeColor)
        {
            EyeColor = val_eyeColor;
        }
        
        //Methods
        public string GetBeach(string eyeColor)
        {
            if(eyeColor == "green")
            {
                return "Seal Beach";
            }
            else if(eyeColor == "brown")
            {
                return "Newport Beach";
            }
            else if(eyeColor == "grey")
            {
                return "Huntington Beach";
            }
            else
            {
                return " ";
            }
        }
        public string GetHotel(double num, string value)
        {
            if ((num >=6 && num <= 10) && value == "Seal Beach")
            {
                return "Hilton";
            }
            else if ((num > 10 && num <= 12) && value == "Huntington Beach")
            {
                return "Best Western";
            }
            else if(num > 12 && value == "Newport Beach")
            {
                return "Marriott";
            }
            else
            {
                return (null);
            }
        }

        public string GetNames()
        {
            if (Names.Count > 0 && Names.Count <= 4)
            {
                return ("Toyota");
            }
            return null;
        }
    }
}