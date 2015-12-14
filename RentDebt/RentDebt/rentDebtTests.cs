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

        [TestMethod]
        public void RentDebtAfewWeeksLate()
        {
            Assert.AreEqual(160, CalculateRentDebt(100, 12));
        }

        [TestMethod]
        public void RentDebtMoreThanAMonthLate()
        {
            Assert.AreEqual(420, CalculateRentDebt(100, 32));
        }

        decimal CalculateRentDebt(int rent, int numberOfDaysLate)
        {
            decimal totalRentDebt = rent;
            if ((numberOfDaysLate > 0) && (numberOfDaysLate <= 10))
                totalRentDebt = rent + numberOfDaysLate * rent * 2 /100;
            else 
                 if ((numberOfDaysLate > 10) && (numberOfDaysLate <=30 ))
                    totalRentDebt = rent + numberOfDaysLate * rent * 5 / 100;
            else
                if ((numberOfDaysLate > 30) && (numberOfDaysLate <= 40))
                totalRentDebt = rent + numberOfDaysLate * rent * 10 / 100;

            return totalRentDebt; 
        }
    }
}
