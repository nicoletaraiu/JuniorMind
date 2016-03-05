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
        public void TestConvertToBase()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, ConvertToBase(2));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1 }, ConvertToBase(5));
            CollectionAssert.AreEqual(new byte[] { 0 }, ConvertToBase(0));
            CollectionAssert.AreEqual(new byte[] { 1, 4 }, ConvertToBase(12, 8));
            CollectionAssert.AreEqual(new byte[] { 1, 2, 1, 0, 2 }, ConvertToBase(146, 3));
            CollectionAssert.AreEqual(new byte[] { 9, 8 }, ConvertToBase(152, 16));

        }

        [TestMethod]
        public void TestGetAt()
        {
            Assert.AreEqual(0, GetAt(new byte[] { 0, 1 }, 3));
            Assert.AreEqual(1, GetAt(new byte[] { 1, 0, 1, 1 }, 3));
        }

        [TestMethod]
        public void TestCountZeros()
        {
            Assert.AreEqual(3, CountZeros(new byte[] { 0, 1, 0, 0, 0 }));
            Assert.AreEqual(2, CountZeros(new byte[] { 0, 0, 0 }));
            Assert.AreEqual(2, CountZeros(new byte[] { 1, 1, 1, 0, 0 }));
        }

        [TestMethod]
        public void TestANDlogic()
        {
            CollectionAssert.AreEqual(ConvertToBase(1 & 11), ANDlogic(ConvertToBase(1), ConvertToBase(11)));
            CollectionAssert.AreEqual(ConvertToBase(0 & 5), ANDlogic(ConvertToBase(0), ConvertToBase(5)));
            CollectionAssert.AreEqual(ConvertToBase(25 & 3), ANDlogic(ConvertToBase(25), ConvertToBase(3)));
        }

        [TestMethod]
        public void TestNOTlogic()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 0 }, NOTlogic(new byte[] { 1, 1, 0, 0, 1 }));

        }
        [TestMethod]
        public void TestORlogic()
        {

            CollectionAssert.AreEqual(ConvertToBase(0 | 5), ORlogic(ConvertToBase(0), ConvertToBase(5)));
            CollectionAssert.AreEqual(ConvertToBase(25 | 3), ORlogic(ConvertToBase(25), ConvertToBase(3)));
        }

        [TestMethod]
        public void TestXORlogic()
        {

            CollectionAssert.AreEqual(ConvertToBase(0 ^ 5), XORlogic(ConvertToBase(0), ConvertToBase(5)));
            CollectionAssert.AreEqual(ConvertToBase(25 ^ 3), XORlogic(ConvertToBase(25), ConvertToBase(3)));
        }
        [TestMethod]
        public void LessThan()
        {

            Assert.AreEqual(0 < 5, LessThan(ConvertToBase(0), ConvertToBase(5)));
            Assert.AreEqual(5 < 25, LessThan(ConvertToBase(5), ConvertToBase(25)));
            Assert.AreEqual(30 < 25, LessThan(ConvertToBase(30), ConvertToBase(25)));
            Assert.AreEqual(8 < 2, LessThan(ConvertToBase(8), ConvertToBase(2)));
            Assert.AreEqual(12 < 5, LessThan(ConvertToBase(12, 16), ConvertToBase(5, 16), 16));
            Assert.AreEqual(3 < 15, LessThan(ConvertToBase(3, 7), ConvertToBase(15, 7), 7));

        }

        [TestMethod]
        public void RightHandShift()
        {

            CollectionAssert.AreEqual(ConvertToBase(8 >> 3), RightHandShift(ConvertToBase(8), 3));
            CollectionAssert.AreEqual(ConvertToBase(25 >> 4), RightHandShift(ConvertToBase(25), 4));


        }
        [TestMethod]
        public void LeftHandShift()
        {

            CollectionAssert.AreEqual(ConvertToBase(8 << 3), LeftHandShift(ConvertToBase(8), 3));
            CollectionAssert.AreEqual(ConvertToBase(25 << 4), LeftHandShift(ConvertToBase(25), 4));


        }

        [TestMethod]
        public void Addition()
        {

            CollectionAssert.AreEqual(ConvertToBase(7 + 8), Addition(ConvertToBase(7), ConvertToBase(8)));
            CollectionAssert.AreEqual(ConvertToBase(26 + 9), Addition(ConvertToBase(26), ConvertToBase(9)));
            CollectionAssert.AreEqual(ConvertToBase(25 + 5), Addition(ConvertToBase(25), ConvertToBase(5)));
            CollectionAssert.AreEqual(ConvertToBase(4 + 18), Addition(ConvertToBase(4), ConvertToBase(18)));
            CollectionAssert.AreEqual(ConvertToBase((26 + 9), 8), Addition(ConvertToBase(26, 8), ConvertToBase(9, 8), 8));
            CollectionAssert.AreEqual(ConvertToBase((25 + 5), 4), Addition(ConvertToBase(25, 4), ConvertToBase(5, 4), 4));
            CollectionAssert.AreEqual(ConvertToBase((4 + 18), 16), Addition(ConvertToBase(4, 16), ConvertToBase(18, 16),16));
        }

        [TestMethod]
        public void Substraction()
        {

            CollectionAssert.AreEqual(ConvertToBase(15 - 5), Substraction(ConvertToBase(15), ConvertToBase(5)));
            CollectionAssert.AreEqual(ConvertToBase(25 - 18), Substraction(ConvertToBase(25), ConvertToBase(18)));
            CollectionAssert.AreEqual(ConvertToBase(0), Substraction(ConvertToBase(12), ConvertToBase(15)));
            CollectionAssert.AreEqual(ConvertToBase((25 - 18), 12), Substraction(ConvertToBase(25, 12), ConvertToBase(18, 12),12));
            CollectionAssert.AreEqual(ConvertToBase((52 - 13), 9), Substraction(ConvertToBase(52, 9), ConvertToBase(13, 9), 9));
        }

        [TestMethod]
        public void Multiplication()
        {

            CollectionAssert.AreEqual(ConvertToBase(3 * 4), Multiplication(ConvertToBase(3), ConvertToBase(4)));
            CollectionAssert.AreEqual(ConvertToBase(5 * 12), Multiplication(ConvertToBase(5), ConvertToBase(12)));
            CollectionAssert.AreEqual(ConvertToBase(12 * 14), Multiplication(ConvertToBase(12), ConvertToBase(14)));
            CollectionAssert.AreEqual(ConvertToBase(10 * 5), Multiplication(ConvertToBase(10), ConvertToBase(5)));
            CollectionAssert.AreEqual(ConvertToBase((4 * 18), 16), Multiplication(ConvertToBase(4, 16), ConvertToBase(18, 16), 16));
            CollectionAssert.AreEqual(ConvertToBase((10 * 5), 3), Multiplication(ConvertToBase(10, 3), ConvertToBase(5, 3), 3));



        }
        [TestMethod]
        public void Division()
        {
            CollectionAssert.AreEqual(ConvertToBase(10 / 5), Division(ConvertToBase(10), ConvertToBase(5)));
            CollectionAssert.AreEqual(ConvertToBase((12/6), 16), Division(ConvertToBase(12, 16), ConvertToBase(6, 16), 16));
            CollectionAssert.AreEqual(ConvertToBase((54 / 6), 3), Division(ConvertToBase(54, 3), ConvertToBase(6, 3), 3));
        }

        [TestMethod]
        public void GraterThan()
        {
            Assert.AreEqual(6 > 3, GraterThan(ConvertToBase(6), ConvertToBase(3)));
            Assert.AreEqual(8 > 2, GraterThan(ConvertToBase(8), ConvertToBase(2)));
            Assert.AreEqual(11 > 24, GraterThan(ConvertToBase(11), ConvertToBase(24)));
            Assert.AreEqual(17 > 4, GraterThan(ConvertToBase(17, 18), ConvertToBase(4, 18), 18));
            Assert.AreEqual(5 > 88, GraterThan(ConvertToBase(5, 6), ConvertToBase(88, 6), 6));
        }

        [TestMethod]
        public void Equal()
        {
            Assert.AreEqual(6 == 6, Equal(ConvertToBase(6), ConvertToBase(6)));
            Assert.AreEqual(8 == 8, Equal(ConvertToBase(8), ConvertToBase(8)));
            Assert.AreEqual(11 == 24, Equal(ConvertToBase(11), ConvertToBase(24)));
        }

        [TestMethod]
        public void NotEqual()
        {
            Assert.AreEqual(6 != 9, NotEqual(ConvertToBase(6), ConvertToBase(9)));
            Assert.AreEqual(8 != 8, NotEqual(ConvertToBase(8), ConvertToBase(8)));
            Assert.AreEqual(11 != 24, NotEqual(ConvertToBase(11), ConvertToBase(24)));
        }


        byte[] ConvertToBase(int number, int newBase = 2)
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
                    converted[pos++] = (byte)(number % newBase);
                    number /= newBase;

                }
            }
            Array.Reverse(converted);
            return converted;
        }

        byte GetAt(byte[] binaryNo, int position)
        {
            return (byte)((position < binaryNo.Length) ? binaryNo[binaryNo.Length - position - 1] : 0);
        }

        int CountZeros(byte[] binaryNo)
        {
            int count = 0;
            int i = binaryNo.Length - 1;
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

        byte[] NOTlogic(byte[] binaryNo)
        {
            for (int i = 0; i < binaryNo.Length; i++)
                binaryNo[i] = (binaryNo[i] == 0) ? (byte)1 : (byte)0;
            return binaryNo;

        }

        byte[] ANDlogic(byte[] first, byte[] second)
        {
            return ExecuteOperation(first, second, "And");
        }

        byte And(byte first, byte second)
        {
            return (byte)(first * second);
        }

        byte[] ORlogic(byte[] first, byte[] second)
        {
            return ExecuteOperation(first, second, "Or");
        }

        byte Or(byte first, byte second)
        {
            return first == 0 && second == 0 ? (byte)0 : (byte)1;
        }

        byte[] XORlogic(byte[] first, byte[] second)
        {
            return ExecuteOperation(first, second, "Xor");
        }

        byte XOr(byte first, byte second)
        {
            return first == second ? (byte)0 : (byte)1;
        }

        byte[] ExecuteOperation(byte[] first, byte[] second, string logicOp)
        {
            byte[] result = new byte[Math.Max(first.Length, second.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = ExecuteOperationSwitch(GetAt(first, i), GetAt(second, i), logicOp);

            }
            Array.Resize(ref result, result.Length - CountZeros(result));
            Array.Reverse(result);
            return result;

        }

        byte ExecuteOperationSwitch(byte first, byte second, string logicOp)
        {
            switch (logicOp)
            {
                case "And":
                    return And(first, second);

                case "Or":
                    return Or(first, second);


            }
            return XOr(first, second);
        }

         bool LessThan(byte[] first, byte[] second, byte newBase = 2)
         {
             for (int i = Math.Max(first.Length, second.Length) -1; i >= 0; i--)
             {
                 if (GetAt(first, i) < GetAt(second, i))
                     return true;
                 else if (GetAt(first, i) > GetAt(second, i))
                     return false;
             }
             return false;

         }
       
        byte[] RightHandShift(byte[] binaryNo, int number)
        {
            Array.Resize(ref binaryNo, binaryNo.Length - number);
            return binaryNo;
        }

        byte[] LeftHandShift(byte[] binaryNo, int number)
        {
            Array.Resize(ref binaryNo, binaryNo.Length + number);
            return binaryNo;
        }

        byte[] Addition(byte[] first, byte[] second, byte newBase = 2)
        {
            byte[] result = new byte[Math.Max(first.Length, second.Length) + 1];
            byte c = 0;
            for (int i = 0; i < result.Length - 1; i++)
            {
                int add = c + GetAt(first, i) + GetAt(second, i);
                result[i] = (byte)(add % newBase);
                c = (byte)(add / newBase);
            }
            result[result.Length - 1] = c;
            Array.Resize(ref result, result.Length - CountZeros(result));
            Array.Reverse(result);
            return result;
        }

        byte[] Substraction(byte[] first, byte[] second, byte newBase = 2)
        {
            if (LessThan(second, first))
            {
                int k = 0;
                byte[] result = new byte[Math.Max(first.Length, second.Length)];
                for (int i = 0; i < result.Length; i++)
                {
                    int diff = newBase + GetAt(first, i) - GetAt(second, i) - k;
                    result[i] = (byte)(diff % newBase);
                    k = diff < newBase ? 1 : 0;
                }
                Array.Resize(ref result, result.Length - CountZeros(result));
                Array.Reverse(result);
                return result;
            }
            return new byte[] { 0 };
        }

        byte[] Multiplication(byte[] first, byte[] second, byte newBase = 2)
        {
            byte[] result = { 0 };
            for (byte[] i = { 0 }; LessThan(i, second); i = Addition(i, new byte[] { 1 }, newBase))
            {
                result = Addition(result, first, newBase);
            }

            return result;

        }

        byte[] Division(byte[] first, byte[] second, byte newBase = 2)
        {
            byte[] result = { 0 };
            while (LessThan(new byte[] { 0 }, first))
            {
                first = Substraction(first, second, newBase);
                result = Addition(result, new byte[] { 1 }, newBase);
            }
            return result;

        }

        bool GraterThan(byte [] first, byte[] second, byte newBase = 2)
        {
            if (LessThan(second, first, newBase))
                return true;
            return false; 
        }
        bool Equal(byte[] first, byte[] second)
        {
            if (!LessThan(second, first) && !LessThan(first, second))
                return true;
            return false;
        }

        bool NotEqual(byte[] first, byte[] second)
        {
            if (LessThan(first, second) || LessThan(second, first))
                return true;
            return false;
        }


    }
}





   