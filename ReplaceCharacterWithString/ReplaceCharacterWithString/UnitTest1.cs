/*Înlocuire
Înlocuiește un caracter dintr-un string cu un alt string.*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReplaceCharacterWithString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReplaceCharacterTest()
        {
            Assert.AreEqual("coffeecoffeecoffeecoffee", ReplaceCharacter("exam", "coffee"));
            Assert.AreEqual("aaa", ReplaceCharacter("bbb", "a"));
        }

        string ReplaceCharacter(string initial, string replace)
        {
            if (initial.Length == 1)
                return replace;
            else
                return replace + ReplaceCharacter(initial.Substring(0, initial.Length - 1), replace);
        }
    }
}
