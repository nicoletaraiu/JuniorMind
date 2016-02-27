/*Ai un număr zecimal transformă-l în baza doi, reprezentat ca și un array de byte (byte[]).

Pentru un număr transformat implementează operațiile:

NOT, AND, NOT, OR, XOR
RightHandShift și LeftHandShift (shiftare de biți la dreapta și la stânga)
LessThan
Adunare și scădere
Înmulțire și împărțire
Folosește-te de LessThan pentru a implementa și alți operatori de comparare (GraterThan, Equal, NotEqual)
Doar pentru numere pozitive.

Poți generaliza transformarea și operațiile de la 3-6 pentru o bază aleatoare (baza fiind între 2 și 255)?*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTwoOperations
{
    [TestClass]
    public class BaseTwoOperationsTests
    {
        [TestMethod]
        public void TestConvertToBinary()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, ConvertToBinary(2));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1 }, ConvertToBinary(5));
            CollectionAssert.AreEqual(new byte[] { 0 }, ConvertToBinary(0));
        }

        [TestMethod]
        public void TestGetAt()
        {
            Assert.AreEqual(0, GetAt(new byte[] { 0,1}, 3));
            Assert.AreEqual(1, GetAt(new byte[] { 1, 0, 1, 1 }, 3));
        }

        [TestMethod]
        public void TestCountZeros()
        {
            Assert.AreEqual(3, CountZeros(new byte[] { 0, 1, 0, 0, 0 }));
            Assert.AreEqual(2, CountZeros(new byte[] { 0, 0, 0 }));
        }

        [TestMethod]
        public void TestANDlogic()
        {
            CollectionAssert.AreEqual(ConvertToBinary(1 & 11), ANDlogic(ConvertToBinary(1), ConvertToBinary(11)));
            CollectionAssert.AreEqual(ConvertToBinary(0 & 5), ANDlogic(ConvertToBinary(0), ConvertToBinary(5)));
            CollectionAssert.AreEqual(ConvertToBinary(25 & 3), ANDlogic(ConvertToBinary(25), ConvertToBinary(3)));
        }

        [TestMethod]
        public void TestNOTlogic()
        {
            CollectionAssert.AreEqual( new byte[] { 0, 0, 1 , 1, 0}, NOTlogic(new byte[] { 1, 1, 0, 0, 1 }));
            CollectionAssert.AreEqual(ConvertToBinary(0 & 5), ANDlogic(ConvertToBinary(0), ConvertToBinary(5)));
            CollectionAssert.AreEqual(ConvertToBinary(25 & 3), ANDlogic(ConvertToBinary(25), ConvertToBinary(3)));
        }

        byte [] ConvertToBinary(int number)
        {
            byte[] converted = new byte[0];
            int pos = 0;
            if (number == 0)
            {
                Array.Resize(ref converted, pos + 1);
                converted[0] = 0;
            }
            else {
                while (number > 0)
                {

                    Array.Resize(ref converted, pos + 1);
                    converted[pos++] = (byte)(number % 2);
                    number /= 2;

                }
            }
                Array.Reverse(converted);
                return converted;
            }

        byte  GetAt(byte [] binaryNo, int position)
        {
            return (byte)((position < binaryNo.Length) ? binaryNo[binaryNo.Length - position - 1] : 0); 
        }
       
        int CountZeros(byte [] binaryNo)
        {
            int count = 0;
            int i = binaryNo.Length-1;
            while (i >= 1)
            {
                if (binaryNo[i] == 0)
                    count++;
                else
                    break;
                i--;
            }
            return count;
        }

        byte[] ANDlogic(byte [] first, byte [] second)
        {
            byte[] result = new byte[Math.Max(first.Length, second.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (byte)(GetAt(first, i) * GetAt(second, i)); 
            }
            Array.Resize(ref result, result.Length - CountZeros(result));
            Array.Reverse(result); 
            return result;
        }

        byte[] NOTlogic(byte [] binaryNo)
        {
            for(int i = 0; i < binaryNo.Length; i++)
             binaryNo[i] = (binaryNo[i] == 0) ? (byte)1 : (byte)0;
            return binaryNo;

        }
        
    }
}
