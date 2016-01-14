/*Anagrame
Pentru un cuvânt dat calculează numărul de anagramări posibile. Nu trebuie ca
cuvintele rezultate să existe în dicționar. Anagramările nu trebuie să se repete 
și nu trebuie generate anagramările, doar să se calculeze numărul lor.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Anagrams
{
    [TestClass]
    public class AnagramsTests
    {
        [TestMethod]
        public void TestIfUniques()
        {
            Assert.AreEqual("abcd", GetUniques("aaabbccd"));
        }

        [TestMethod]
        public void TestIfMatch()
        {
            Assert.AreEqual(2, CountMatches("casa", 'a'));
        }

        [TestMethod]
        public void TestFactorial()
        {
            Assert.AreEqual(120, GetFactorial(5));
        }

        string GetUniques(string word)
        {
            string uniques = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
              if (!uniques.Contains(word[i])){
                    uniques += word[i]; 
                }
            }
            return uniques;
        }
        int CountMatches(string word, char match)
        {
            int matches = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Equals(match))
                    matches++;
            }
            return matches;
        }

        int GetFactorial(int numberOfLetters)
        {
            int factorial = 1;
            for (int i = 1; i <= numberOfLetters; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
     
    }
}
