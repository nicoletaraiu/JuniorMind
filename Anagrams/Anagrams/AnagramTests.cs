/*Anagrame
Pentru un cuvânt dat calculează numărul de anagramări posibile. Nu trebuie ca cuvintele
rezultate să existe în dicționar. Anagramările nu trebuie să se repete și nu trebuie 
generate anagramările, doar să se calculeze numărul lor.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void AnagramsForAShortWord()
        {
            Assert.AreEqual(6, CalculateNumberOfAnagrams("abc"));
        }
        [TestMethod]
        public void AnagramsForALongerWord()
        {
            Assert.AreEqual(720, CalculateNumberOfAnagrams("coding"));
        }
        int CalculateNumberOfAnagrams(string word)
        {
            int numberOfAnagrams = 1;
            for (int i = word.Length; i>0; i--)
            {
                numberOfAnagrams *= i; 
            }
            return numberOfAnagrams; 
        } 
    }
}
