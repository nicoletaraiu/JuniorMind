using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class CandidatesSortedAlphabeticallyTests
    {
        [TestMethod]
        public void SortAlphabeticallyTest()
        {
            var ion = new Candidate("Ion", 314);
            var adam = new Candidate("Adam", 207);
            var dan = new Candidate("Dan", 500);
            var vasile = new Candidate("Vasile", 135);
            var candidates = new Candidate[] { ion, adam, dan, vasile };
            var sortedAlphabetically = new Candidate[] { adam, dan, ion, vasile };



            var firstList = new CandidatesSortedAlphabetically(candidates);
            CollectionAssert.AreEqual(sortedAlphabetically, firstList.SortAlphabetically( candidates, 0, candidates.Length - 1));
        }

        [TestMethod]
        public void MergeTest()
        {
            var adam = new Candidate("Adam", 207);
            var dan = new Candidate("Dan", 500);
            var ion = new Candidate("Ion", 314);

            var candidates = new Candidate[] { adam, dan, ion};
            var aList = new CandidatesSortedAlphabetically(candidates);

            var adamFromAnotherList = new Candidate("Adam", 2);
            var danFromAnotherList = new Candidate("Dan", 2);
            var ionFromAnotherList = new Candidate("Ion", 2);

            var anotherCandidatesList = new Candidate[] {adamFromAnotherList, danFromAnotherList, ionFromAnotherList  };
            var anotherList = new CandidatesSortedAlphabetically(anotherCandidatesList);

            aList.Merge(anotherList);

            var finalAdam = new Candidate("Adam", 209);
            var finalDan = new Candidate("Dan", 502);
            var finalIon = new Candidate("Ion", 316);

            Assert.AreEqual(0, adam.CompareByVotes(finalAdam));
            Assert.AreEqual(0, dan.CompareByVotes(finalDan));
            Assert.AreEqual(0, ion.CompareByVotes(finalIon));
           
        }

     

    }
    
}
