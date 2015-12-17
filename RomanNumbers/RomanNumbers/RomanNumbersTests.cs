﻿/*Convertește un număr dat, între 1 și 1000, în cifre romane.*/
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
        public void ConvertToRoman17()
        {
            Assert.AreEqual("XVII", convertToRomanNumbers(17));
        }

        [TestMethod]
        public void ConvertToRoman56()
        {
            Assert.AreEqual("LVI", convertToRomanNumbers(56));
        }

        string convertToRomanNumbers(int number)
        {
            string[] romanUnitsNumbers = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            string[] romanTensNumbers = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

            return romanTensNumbers[number / 10] + romanUnitsNumbers[number % 10];
            
         }
    }
    
}
