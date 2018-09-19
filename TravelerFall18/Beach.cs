namespace TravelerFall18
{
    public class Beach
    {
        //Fields
        private string eyeColor;
        private double shoeSize;

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
            if (num == 10 && value == "Seal Beach")
            {
                return "Hilton";
            }
            return (null);
        }
    }
}