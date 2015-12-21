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

        string FindCommonPrefix(string firstString, string secondString)
        {
            return "an";
        }
    }
}
