using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerFall18.Tests
{
    //This is the Traveler Application
    //  - take in an eye color and return a beach location
    //  - take in size of shoe and beach and return what hotel you will stay at
    //
    //  - take in length of longest last name and return a car type (ie, sedan)
    //  - take in length of name list and return car make

    [TestFixture]
    class TravelerTests
    {
        Beach beach = new Beach();

        [Test]
        public void Enter_Eye_Color_Set_Property()
        {
            //Arrange
            Beach beach = new Beach("blue");
            //Act
            string response = beach.EyeColor;
            //Assert
            Assert.That(response, Is.EqualTo("blue"));
        }

        [Test]
        public void Enter_Blue_Eye_Color_Return_Empty_String()
        {
            //Arrange
            //^ in setup
            //Act
            string response = beach.GetBeach("blue");
            //Assert
            Assert.That(response, Is.EqualTo(" "));
        }

        [Test]
        public void Enter_Green_Eye_Color_Return_Beach()
        {
            //Arrange
            //^ in setup
            //Act
            string response = beach.GetBeach("green");
            //Assert
            Assert.That(response, Is.EqualTo("Seal Beach"));
        }

        [Test]
        public void Enter_Brown_Eye_Color_Return_Beach()
        {
            string response = beach.GetBeach("brown");
            Assert.That(response, Is.EqualTo("Newport Beach"));
        }

        [Test]
        public void Enter_Grey_Eye_Color_Return_Beach()
        {
            string response = beach.GetBeach("grey");
            Assert.That(response, Is.EqualTo("Huntington Beach"));
        }

        [Test]
        public void Set_Shoe_Size()
        {
            beach.ShoeSize = 10.5;
            double response = beach.ShoeSize;
            Assert.That(response, Is.EqualTo(10.5));
        }

        [Test]
        public void Enter_Shoe_Size_0_Beach_Empty_Return_Hotel_Null()
        {
            string location = beach.GetBeach(" ");
            string response = beach.GetHotel(0, location);
            Assert.That(response, Is.EqualTo(null));
        }

        [Test]
        public void Enter_Shoe_Size_10_And_Seal_Beach_Return_Hotel_Hilton()
        {
            string location = beach.GetBeach("green");
            string response = beach.GetHotel(10, location);
            Assert.That(response, Is.EqualTo("Hilton"));
        }

        [Test]
        public void Enter_Shoe_Size_11_5_And_Huntington_Return_Hotel_BestWestern()
        {
            string location = beach.GetBeach("grey");
            string response = beach.GetHotel(11.5, location);
            Assert.That(response, Is.EqualTo("Best Western"));
        }

        [Test]
        public void Enter_Shoe_Size_12_5_And_Newport_Return_Marriott()
        {
            string location = beach.GetBeach("brown");
            string response = beach.GetHotel(12.5, location);
            Assert.That(response, Is.EqualTo("Marriott"));
        }

        [Test]
        public void Enter_Shoe_Size_6_And_Seal_Beach_Return_Hilton()
        {
            string location = beach.GetBeach("green");
            string response = beach.GetHotel(6, location);
            Assert.That(response, Is.EqualTo("Hilton"));
        }

        [Test]
        public void Enter_Shoe_Size_10_1_And_Huntington_Return_BestWestern()
        {
            string location = beach.GetBeach("grey");
            string response = beach.GetHotel(10.1, location);
            Assert.That(response, Is.EqualTo("Best Western"));
        }

        [Test]
        public void Enter_Shoe_Size_13_And_Newport_Beach_Return_Marriott()
        {
            string location = beach.GetBeach("brown");
            string response = beach.GetHotel(13, location);
            Assert.That(response, Is.EqualTo("Marriott"));
        }

        [Test]
        public void Get_Rental_Car_Make_and_Type_Return_Null()
        {
            //First we want to test for the default condition, which returns null
            beach.Names.Clear();
            string response = beach.GetNames();
            Assert.That(response, Is.EqualTo(null));
        }

        [Test]
        public void Enter_Names_And_Return_Length_True()
        {
            //We want to return the length of the Names property, to make sure that values have been saved
            //Manually fill the List property with a few names
            //Arrange
            beach.Names.Add("Pete");
            beach.Names.Add("Tom");
            //Act
            bool response = beach.Names.Count > 0;
            //Assert
            //Make sure that the list is not null
            Assert.That(response, Is.EqualTo(true));
        }

        [Test]
        public void Enter_0_Names_And_Return_Length_False()
        {
            //We want to return the length of the Names property, to show there are no values
            //List property has no names
            //Arrange
            //Act
            bool response = beach.Names.Count > 0;
            //Assert
            //Make sure that the list is not null
            Assert.That(response, Is.EqualTo(false));
        }

        [Test]
        public void Get_Rental_Car_Make_And_Return_Toyota_Length_True_if_Length_0_to_2()
        {
            beach.Names.Add("Pete");
            beach.Names.Add("Tom");
            string response = beach.GetNames();
            Assert.That(response, Is.EqualTo("Toyota"));
        }
    }
}
