/*Doi prieteni au cumpărat un pepene de X kg, și doresc să îl împartă. Singura lor dorință e ca fiecare să 
primească un număr par de kg din pepene. E ok și dacă nu primesc aceeași cantitate.
Scrie un program care răspunde cu DA dacă pepenele poate fi împărțit cum își doresc cei doi prieteni,
și cu NU în caz contrar.*/


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestPepene
    {
        [TestMethod]
        public void TestMethod1()
        {
            string raspunsNrParDeKg = raspuns(12);

            Assert.AreEqual("Da", raspunsNrParDeKg); 
        }
        string raspuns(int totalKgPepene) {
            int parity = totalKgPepene % 2;
            return parity == 0 ? "Da" : "Nu";

        }
    }
}
