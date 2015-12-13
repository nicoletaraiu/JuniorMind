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
        public void NumarParDeKg()
        {
            string raspunsNrParDeKg = raspuns(12);

            Assert.AreEqual("Da", raspunsNrParDeKg); 
        }
        [TestMethod]
        public void NumarNuE2()
        {
            string raspunsNr2 = raspuns(2);
             Assert.AreEqual("Nu", raspunsNr2);
        }

        string raspuns(int totalKgPepene) {
            string rasp = "Nu";
            if ((totalKgPepene % 2 == 0) && (totalKgPepene != 2))
                rasp = "Da";
            return rasp; 

            

        }
    }
}
