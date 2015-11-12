using System;
using ConsoleApplication1;
using NUnit.Framework;

namespace DemoTest
{
    [TestFixture]
    public class PersonTest
    {
        [Test]
        public void FullName_Valid_DisplayCorrectFullName()
        {
            //Arrange
            Person p = new Person();
            p.FirstName = "Bill";
            p.LastName = "Clinton";

            //Act
            String result = p.FullName;

            //Assert
            Assert.AreEqual("Bill Clinton", result);


        }


        [Test]
        public void Age_Validage_calculatesCorrectly()
        {
            //Arrange
            Person p = new Person();
            p.DateOfBirth = new DateTime(1992,05,13);

            //Act
            int result = p.Age;

            //Assert
            Assert.AreEqual(23, result);


        }


        [Test]
        public void ZodiacSign_DisplayCorrectSign()
        {
            //Arrange
            Person p = new Person();
            p.DateOfBirth = new DateTime(1992, 05, 13);

            //Act
            String ZodiacSign = p.ZodiacSign;

            //Assert
            Assert.AreEqual("Taurus", ZodiacSign);
        }
    }

}


