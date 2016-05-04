using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class SortTests
    {
        [TestMethod]
        public void SortAlphabeticallyTest()
        {
            var candidates = new Candidate[] {
                new Candidate ("Ion", 314),
                new Candidate("Adam", 207),
                new Candidate("Dan", 500),
                new Candidate("Vasile", 135) };

            var sorted = new Candidate[] {
                new Candidate("Adam", 207),
                new Candidate("Dan", 500),
                new Candidate("Ion", 314),
                new Candidate("Vasile", 135) };

            Sort S1 = new Sort(candidates);
            CollectionAssert.AreEqual(sorted, S1.SortAlphabetically());
        }

    }
    
}
