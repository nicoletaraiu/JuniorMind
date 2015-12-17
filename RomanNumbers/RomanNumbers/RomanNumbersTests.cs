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

        [TestMethod]
        public void ConvertToRoman17()
        {
            Assert.AreEqual("XVII", convertToRomanNumbers(17));
        }

        string convertToRomanNumbers(int number)
        {
            string[] romanUnitsNumbers = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            string[] romanTensNumbers = { "", "X" };

            return romanTensNumbers[number / 10] + romanUnitsNumbers[number % 10];
            
         }
    }
    
}
