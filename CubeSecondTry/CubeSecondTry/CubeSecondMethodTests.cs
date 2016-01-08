/*Cub
Un om de știință vrea să știe toate numerele al căror cub se termină cu 888. Ajută-l prin 
a-i face un program care pentru numărul k, întoarce al k-lea număr al cărui cub e 888.

Exemplu: dacă k e 1, rezultatul e 192*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeSecondTry
{
    [TestClass]
    public class CubeSecondTryTests
    {
        [TestMethod]
        public void FirstNumberWithCubeEndingIn888()
        {
            Assert.AreEqual(192, CalculateTheKNumberWithCubeEndingIn888(1));
        }
        [TestMethod]
        public void The17thNumberWithCubeEndingIn888()
        {
            Assert.AreEqual(4192, CalculateTheKNumberWithCubeEndingIn888(17));
        }

        int  CalculateTheKNumberWithCubeEndingIn888(int k)
        {
            return (k-1)*250 + 192;
        }
    }
}
