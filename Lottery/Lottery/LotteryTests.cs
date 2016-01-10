/*Loto 6 din 49
Vrei să participi la jocul de noroc 6 din 49 cu o singură variantă (simplă).

Calculează ce șanse ai să câștigi la categoria I (6 numere)?

Calculează ce șanse ai să câștigi la categoria II (5 numere)?

Calculează ce șanse ai să câștigi la categoria III (4 numere)?

Calculează și ce șanse ai la categoria I la 5 din 40?*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lottery
{
    [TestClass]
    public class LotteryTests
    {
        [TestMethod]
        public void TestFor1from49()
        {
            Assert.AreEqual(0.020, CalculateChancesToWin(1, 49));
        }

        double CalculateChancesToWin(int numbers, int totalNumbers)
        {
            double chance; 
            chance = (double)1/49;
            return (Math.Round(chance, 3)); 
        }
    }
}
