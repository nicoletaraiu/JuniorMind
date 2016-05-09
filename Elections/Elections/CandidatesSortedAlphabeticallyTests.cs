﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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



            CandidatesSortedAlphabetically firstList = new CandidatesSortedAlphabetically(candidates);
            CollectionAssert.AreEqual(sortedAlphabetically, firstList.SortAlphabetically( candidates, 0, candidates.Length - 1));
        }

     

    }
    
}
