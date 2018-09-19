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
    //  - take in size of shoe and return what hotel you will stay at

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

    }
}
