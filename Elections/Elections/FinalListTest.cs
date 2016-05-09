using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    [TestClass]
    public class FinalListTestClass
    {
        [TestMethod]
        public void MergeAllListsTest()
        {
            var adam = new Candidate("Adam", 207);
            var dan = new Candidate("Dan", 500);
            var ion = new Candidate("Ion", 314);

            var candidates = new Candidate[] { adam, dan, ion };
            var firstList = new CandidatesSortedAlphabetically(candidates);

            var adamFromSecondList = new Candidate("Adam", 2);
            var danFromSecondList = new Candidate("Dan", 2);
            var ionFromSecondList = new Candidate("Ion", 2);

            var anotherList = new Candidate[] { adamFromSecondList, danFromSecondList, ionFromSecondList };
            var secondList = new CandidatesSortedAlphabetically(anotherList);

            var adamFromThirdList = new Candidate("Adam", 1);
            var danFromThirdList = new Candidate("Dan", 1);
            var ionFromThirdList = new Candidate("Ion", 1);

            var list = new Candidate[] { adamFromThirdList, danFromThirdList, ionFromThirdList };
            var thirdList = new CandidatesSortedAlphabetically(list);


            var finalAdam = new Candidate("Adam", 210);
            var finalDan = new Candidate("Dan", 503);
            var finalIon = new Candidate("Ion", 317);

            var lists = new CandidatesSortedAlphabetically[] { firstList, secondList, thirdList };
            var finalList = new FinalList(3, lists);
            finalList.MergeAllLists();

            Assert.AreEqual(0, adam.CompareByName(finalAdam));
            Assert.AreEqual(0, dan.CompareByName(finalDan));
            Assert.AreEqual(0, ion.CompareByVotes(finalIon));

            Assert.AreEqual(0, adam.CompareByVotes(finalAdam));
            Assert.AreEqual(0, dan.CompareByVotes(finalDan));
            Assert.AreEqual(0, ion.CompareByVotes(finalIon));
          }

        }

    }
