/*Turnurile din Hanoi
Călugării dintr-un templul din Benares trebuie să mute 64 de discuri de pe un turn pe altul.
În afară de cele două turnuri mai au la dispoziție un singur alt turn care e suficient de sacru pentru a putea fi folosit.
Cele 64 de discuri au dimensiuni diferite. Iar călugării trebuie să respecte două reguli:
un singur disc poate fi mutat la un moment dat
un disc mai mare nu poate fi mutat peste un disc mai mic*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTowers
{
    [TestClass]
    public class HanoiTowersTests
    {
        [TestMethod]
        public void TestFor3Disks()
        {
            int[] source = new int[] { 7, 3, 2 };
            int[] dest = new int[source.Length];
            int[] spare = new int[source.Length];

            CollectionAssert.AreEqual(new int[] {7, 3, 2 }, GetTower(3, source, dest, spare));
        }
        [TestMethod]
        public void TestFor8Disks()
        {
            int[] source = new int[] { 19, 14, 11, 9, 8, 5, 3, 2 };
            int[] dest = new int[source.Length];
            int[] spare = new int[source.Length];

            CollectionAssert.AreEqual(new int[] { 19, 14, 11, 9, 8, 5, 3, 2 }, GetTower(8, source, dest, spare));
        }

        int[] GetTower(int noOfDisks, int[] source, int[] dest, int[] spare)
        {
            if (noOfDisks == 0)
            {
                dest[noOfDisks] = source[noOfDisks];
                Array.Resize(ref source, source.Length - 1);
                return dest; 
            }
            GetTower(noOfDisks - 1, source, spare, dest);
            dest[noOfDisks - 1] = source[noOfDisks - 1];
            Array.Resize(ref source, source.Length - 1);
            GetTower(noOfDisks - 1, spare, dest, source);
            return dest; 
        }
    }
}
