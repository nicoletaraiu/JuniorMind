/*Triunghiul lui Pascal
Generează triunghiul lui Pascal pentru un nivel dat folosindu-te de recursivitate.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalsTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForTheFirstLevel()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, GeneratePascalsTriangle(1));
            
        }

        [TestMethod]
        public void TestForTheSecondLevel()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1 }, GeneratePascalsTriangle(2));

        }

        [TestMethod]
        public void TestForTheSixthLevel()
        {
            CollectionAssert.AreEqual(new int[] { 1, 5, 10, 10, 5, 1 }, GeneratePascalsTriangle(6));

        }

        int[] GeneratePascalsTriangle(int level)
        {
            int[] row = new int[level];
            if (level == 1)
                return new int[] { 1 };
            else {
                row[0] = 1;
                row[level - 1] = 1;
                int[] previousRow = GeneratePascalsTriangle(level - 1);

                for (int i = 1; i < level - 1; i++)
                    row[i] = previousRow[i - 1] + previousRow[i];

                return row;
            }     

        }
    }
}
