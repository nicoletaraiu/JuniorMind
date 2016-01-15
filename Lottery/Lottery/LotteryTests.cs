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
        public void TestFor6from49()
        {
            Assert.AreEqual(0.0000000715, CalulateChancesToGetNnumbers(6, 6, 49));
        }

        [TestMethod]
        public void TestFor5from49()
        {
            Assert.AreEqual(0.0000184499, CalulateChancesToGetNnumbers(5, 6, 49));
        }
        [TestMethod]
        public void TestFor4from49()
        {
            Assert.AreEqual(0.0009686197, CalulateChancesToGetNnumbers(4, 6, 49));
        }

        double CalculateChances(double totalNumbers, double numbers)
        {
            double chance = 1; 
            for (double i = numbers; i > 0; i--)
            {
                chance *= totalNumbers / i;
                totalNumbers--;
            }
            
            return chance; 
        }
        double CalulateChancesToGetNnumbers(double n, double allNumbers, double totalNumbers)
        {
            double chanceToGetNoIwant = 0;
            chanceToGetNoIwant = CalculateChances(allNumbers, n) * CalculateChances(totalNumbers - allNumbers, allNumbers - n)/ CalculateChances(totalNumbers, allNumbers);
            return Math.Round(chanceToGetNoIwant, 10);

        }
    }
}
