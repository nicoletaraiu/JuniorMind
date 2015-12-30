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
        public void TestIfPanagram()
        {
            Assert.AreEqual("Panagram", CheckIfPangram("The quick brown fox jumps over the lazy dog"));
        }
        [TestMethod]
        public void TestIfNotPanagram()
        {
            Assert.AreEqual("Not panagram", CheckIfPangram("The quick brown fox"));
        }


        string CheckIfPangram(string phrase)
        {
            string phraseAllLower = phrase.ToLower();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int counterOfLetters = 0; 
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (phraseAllLower.IndexOf(alphabet[i]) != -1)
                    counterOfLetters++;
                else break;
            }

            if (counterOfLetters == 26)
                return "Panagram";
            else
                return "Not panagram"; 
        }
    }
}
