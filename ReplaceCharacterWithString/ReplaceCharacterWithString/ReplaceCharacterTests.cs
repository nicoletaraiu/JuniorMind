/*Înlocuire
Înlocuiește un caracter dintr-un string cu un alt string.*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReplaceCharacterWithString
{
    [TestClass]
    public class ReplaceCharacterTests
    {
        [TestMethod]
        public void ReplaceCharacterTest()
        {
            Assert.AreEqual("teaaat", ReplaceCharacter("test", "aaa", 's'));
            Assert.AreEqual("ctxstx", ReplaceCharacter("casa", "tx", 'a'));
        }

        string ReplaceCharacter(string initial, string replace, char toBeReplaced)
        {

            if (initial.Length == 1)
            {
                if (initial[0] == toBeReplaced)
                    return replace;
                else
                    return initial[0].ToString();
            }

            else
                if (initial[initial.Length - 1] == toBeReplaced)
                return ReplaceCharacter(initial.Substring(0, initial.Length - 1), replace, toBeReplaced) + replace;
            else
                return ReplaceCharacter(initial.Substring(0, initial.Length - 1), replace, toBeReplaced) + initial[initial.Length - 1];
        }
    }
}
