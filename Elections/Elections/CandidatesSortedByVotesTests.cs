using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void SortByVotesTest()
        {
            var ion = new Candidate("Ion", 314);
            var adam = new Candidate("Adam", 207);
            var dan = new Candidate("Dan", 500);
            var vasile = new Candidate("Vasile", 135);
            var sergiu = new Candidate("Sergiu", 95);
            var candidates = new Candidate[] { ion, adam, dan, vasile, sergiu };
            var sortedByVotes = new Candidate[] { dan, ion, adam, vasile, sergiu };

            var listOfCandidates = new CandidatesSortedByVotes(candidates);
            CollectionAssert.AreEqual(sortedByVotes, listOfCandidates.SortByVotes(candidates));
        }

    }
   
}
