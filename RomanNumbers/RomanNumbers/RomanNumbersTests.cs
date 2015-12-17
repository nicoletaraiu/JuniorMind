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

        string convertToRomanNumbers(int number)
        {
            return "I";
        }
    }
    
}
