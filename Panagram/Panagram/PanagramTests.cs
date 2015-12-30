/*Panagram
Un panagram e o frază care conține toate literele din alfabet (englezesc). Scrie un program 
care determină dacă o frază e o panagram.
Exemplu: The quick brown fox jumps over the lazy dog*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class PanagramTests
    {
       

        [TestMethod]
        public void TestIfTheFirst10LettersAppear()
        {
            Assert.AreEqual("Yes", CheckIfPangram("abcdefghij 12"));
        }

        string CheckIfPangram(string phrase)
        {
            //  if ((phrase.IndexOf("a") != -1) && (phrase.IndexOf("b") != -1) && (phrase.IndexOf("c") != -1))
            //   return "Yes";
            // else
            string alphabet = "abcdefghij";
            int counterOfLetters = 0; 
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (phrase.IndexOf(alphabet[i]) != -1)
                    counterOfLetters++;
                else break;
            }

            if (counterOfLetters == 10)
                return "Yes";
            else
                return "No"; 
        }
    }
}
