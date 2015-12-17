/*Convertește un număr dat, între 1 și 100, în cifre romane.*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class RomanNumbersTests
    {
        [TestMethod]
        public void ConvertToRoman1()
        {
            Assert.AreEqual("I", convertToRomanNumbers(1));
        }
        [TestMethod]
        public void ConvertToRoman2()
        {
            Assert.AreEqual("II", convertToRomanNumbers(2));
        }
        [TestMethod]
        public void ConvertToRoman3()
        {
            Assert.AreEqual("III", convertToRomanNumbers(3));
        }

        string convertToRomanNumbers(int number)
        {
            string[] romanNumbers = { "", "I", "II", "III" };
            
                return romanNumbers[number]; 
            

 
                 

        }
    }
    
}
