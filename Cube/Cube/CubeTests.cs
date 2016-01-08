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
        public void FirstNumberWithCubeEndingIn888()
        {
            Assert.AreEqual(192, CalculateTheKNumberWithCubeEndingIn888(1));
        }
        [TestMethod]
        public void Number5thWithCubeEndingIn888()
        {
            Assert.AreEqual(1192, CalculateTheKNumberWithCubeEndingIn888(5));
        }

        [TestMethod]
        public void Number14thWithCubeEndingIn888()
        {
            Assert.AreEqual(3442, CalculateTheKNumberWithCubeEndingIn888(14));
        }

        int CalculateTheKNumberWithCubeEndingIn888(int k)
        {
            int number = 192;
           long  cubeOfNumber = 0;
            int numberOfCubesFound = 1; 
            while (numberOfCubesFound < k)
            {
                number++;
                cubeOfNumber = number * number * number;
                if ((cubeOfNumber % 1000 == 888)) 
                    numberOfCubesFound++;
                
            }

            return number;
        }
    }
}
