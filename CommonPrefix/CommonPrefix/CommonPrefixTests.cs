/*Dacă ai două stringuri, găsește-le prexiul comun. Exemplu: aaab și aaaabbaa au prefixul comun aaa*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonPrefix
{
    [TestClass]
    public class CommonPrefixTests
    {
        [TestMethod]
        public void CommonPrefixForTwoShortStrings()
        {
            Assert.AreEqual("an", FindCommonPrefix("an", "ana"));
        }

        [TestMethod]
        public void CommonPrefixForTwoLongerStrings()
        {
            Assert.AreEqual("aan", FindCommonPrefix("aanca", "aanaabb"));
        }

        [TestMethod]
        public void WhenTheStringsHaveNoCommonPrefix()
        {
            Assert.AreEqual("NoCommonPrefix", FindCommonPrefix("christmas", "newYear"));
        }

        string FindCommonPrefix(string firstString, string secondString)
        {
            string prefix = string.Empty;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] == secondString[i])
                {
                    prefix += firstString[i];
                }
                else
                    break; 
                  }
            if (prefix == "")
                return "NoCommonPrefix";
            else
                return prefix; 

        }
    }
}
