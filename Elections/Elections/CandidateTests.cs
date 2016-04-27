/*Centralizare alegeri
La alegeri fiecare secție de votare trimite o listă de candidați și numărul de voturi.
Listele sunt ordonate descrescător în funcție de numărul de voturi.
Crează o funcție care să ajute la centralizarea voturilor.*/


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elections
{
    [TestClass]
    public class CandidateTests
    {
        [TestMethod]
        public void CompareByNameTest()
        {
            Candidate C1 = new Candidate("Adam", 300);
            Candidate C2 = new Candidate("Ion", 345);
            Candidate C3 = new Candidate("Ion", 125);
            Assert.AreEqual(1, C1.CompareByName(C2));
            Assert.AreEqual(0, C2.CompareByName(C3));

        }
    }
}
