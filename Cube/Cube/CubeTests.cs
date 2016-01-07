/*Cub
Un om de știință vrea să știe toate numerele al căror cub se termină cu 888. Ajută-l prin 
a-i face un program care pentru numărul k, întoarce al k-lea număr al cărui cub e 888.

Exemplu: dacă k e 1, rezultatul e 192*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void FirstNumberWithCubeEndingIn8()
        {
            Assert.AreEqual(2, CalculateTheKNumberWithCubeEndingIn8(1));
        }

        int CalculateTheKNumberWithCubeEndingIn8(int k)
        {
            int number = 1;
            int cubeOfNumber = 0;
            int numberOfCubesFound = 0; 
            while (numberOfCubesFound != k)
            {
                cubeOfNumber = number * number * number;
                if (cubeOfNumber % 10 == 8)
                    numberOfCubesFound++;
                else
                    number++; 
            }

            return number;
        }
    }
}
