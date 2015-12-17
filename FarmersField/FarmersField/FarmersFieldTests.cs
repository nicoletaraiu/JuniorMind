/*Un fermier are un teren pătrat. Pentru a-și extinde suprafața a mai cumpărat o parcelă 
alăturată. Noua parcelă are acceași lungime și are o lățime de 230m. Acum fermierul are
un teren de 77ha (770.000mp).
Ce dimensiune avea inițial terenul?*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmersField
{
    [TestClass]
    public class FarmersFieldTests
    {
        [TestMethod]
        public void CalculateInitialDimmensionForASmallField()
        {
            Assert.AreEqual(4, initialFieldDimension(4, 12));

        }
        [TestMethod]
        public void CalculateInitialDimmensionForABiggerField()
        {
            Assert.AreEqual(225, initialFieldDimension(16, 465));

        }
        [TestMethod]
        public void CalculateInitialDimmensionWhenDeltaSmallerThan0()
        {
            Assert.AreEqual(0, initialFieldDimension(4, -12));

        }
        double initialFieldDimension(int newFieldWidth, int finalFieldDimension)
        {
            double Delta = newFieldWidth * newFieldWidth - 4 * (-finalFieldDimension);
            if (Delta >= 0)
            {
                double L = (-newFieldWidth + Math.Sqrt(Delta)) / 2;
                return L * L;
            }
            else
                return 0;
        }
    }
}
