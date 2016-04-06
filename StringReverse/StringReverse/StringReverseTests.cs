/*Inversare
Inversează un string folosind recursivitatea.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringReverse
{
    [TestClass]
    public class StringReverseTests
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            Assert.AreEqual("fedcba", ReverseString("abcdef"));
        }

        string ReverseString(string toReverse)
        {
            if (toReverse.Length == 1)
                return toReverse;
             return toReverse[toReverse.Length-1] + ReverseString(toReverse.Substring(0, toReverse.Length -1));
        }
    }
}
