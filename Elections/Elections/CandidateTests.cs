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
            var adam = new Candidate("Adam", 300);
            var ion = new Candidate("Ion", 345);
            var ionFromOtherList = new Candidate("Ion", 125);
            var andrei = new Candidate("Andrei", 300);
            Assert.AreEqual(1, adam.CompareByName(ion));
            Assert.AreEqual(0, ion.CompareByName(ionFromOtherList));
            Assert.AreEqual(0, adam.CompareByVotes(andrei));
            Assert.AreEqual(-1, ionFromOtherList.CompareByVotes(ion));
            Assert.AreEqual(-1, ion.CompareByName(adam));

        }

        [TestMethod]
        public void MergeVotesTest()
        {
            var ion = new Candidate("Ion", 345);
            var ionFromOtherList = new Candidate("Ion", 125);
            ion.MergeVotes(ionFromOtherList);
            var ionFinal = new Candidate("Ion", 470); 
            Assert.AreEqual(0, ion.CompareByVotes(ionFinal));
        }
    }
}
