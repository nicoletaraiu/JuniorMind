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
            Assert.AreEqual(0.0000000715, CalculateChancesToWin(6, 49));
        }

        double CalculateChancesToWin(double numbers, double totalNumbers)
        {
            double chance = 1; 
            for (double i = numbers; i > 0; i--)
            {
                chance *= i / totalNumbers;
                totalNumbers--;
            }
            
            
            return (Math.Round(chance, 10)); 
        }
    }
}
