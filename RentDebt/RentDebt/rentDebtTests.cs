/*Ai de plătit chiria lunară. Dar cu fiecare zi de întârziere trebuie să plătești o penalitate.

Dacă ai întârziat:

1-10 zile - plătești o penalitate de 2% din chirie/zi întârzire
11-30 zile - plătești o penalitate de 5% din chirie/zi întârzire
31-40 zile - plătești o penalitate de 10% din chirie/zi întârzire
Dacă ști chiria și numărul de zile de întârziere, calculează suma totală de plată.*/


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentDebt
{
    [TestClass]
    public class rentDebtTests
    {
        [TestMethod]
        public void RentDebtAfewDaysLate()
        {
            Assert.AreEqual(104, CalculateRentDebt(100, 2));
        }

        decimal CalculateRentDebt(int rent, int numberOfDaysLate)
        {
            return (rent + numberOfDaysLate * rent * 2 / 100); 
        }
    }
}
