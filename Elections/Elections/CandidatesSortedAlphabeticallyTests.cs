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
            var candidates = new Candidate[] {
                new Candidate ("Ion", 314),
                new Candidate("Adam", 207),
                new Candidate("Dan", 500),
                new Candidate("Vasile", 135) };

            var sortedAlphabetically = new Candidate[] {
                new Candidate("Adam", 207),
                new Candidate("Dan", 500),
                new Candidate("Ion", 314),
                new Candidate("Vasile", 135) };

          

            CandidatesSortedAlphabetically S1 = new CandidatesSortedAlphabetically(candidates);
            CollectionAssert.AreEqual(sortedAlphabetically, S1.SortAlphabetically(ref candidates));
        }

      /*  [TestMethod]
        public void SortByNumberOfVotes()
        {

            var candidates = new Candidate[] {
                new Candidate ("Ion", 314),
                new Candidate("Adam", 207),
                new Candidate("Dan", 500),
                new Candidate("Vasile", 135) };

            var sortedByVotes = new Candidate[]
          {
                new Candidate("Dan", 500),
                new Candidate("Ion", 314),
                new Candidate("Adam", 207),
                new Candidate("Vasile", 135)
         };
            CandidatesSortedAlphabetically S2 = new CandidatesSortedAlphabetically(candidates);
            CollectionAssert.AreEqual(sortedByVotes, S2.SortByNoOfVotes(ref candidates));
        }*/

    }
    
}
