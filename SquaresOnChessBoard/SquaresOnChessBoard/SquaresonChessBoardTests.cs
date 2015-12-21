/*Calculează câte pătrate se pot forma pe o tablă de șah de dimensiunea de 8 x 8.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquaresOnChessBoard
{
    [TestClass]
    public class SquaresonChessBoardTests
    {
        [TestMethod]
        public void SquaresOnA2x2Board()
        {
            Assert.AreEqual(5, CalculateSquaresOnChessBoard(2));
        }
        [TestMethod]
        public void SquaresOnA3x3Board()
        {
            Assert.AreEqual(14, CalculateSquaresOnChessBoard(3));
        }
        [TestMethod]
        public void SquaresOnA4x4Board()
        {
            Assert.AreEqual(30, CalculateSquaresOnChessBoard(4));
        }

        int CalculateSquaresOnChessBoard(int number)
        {
            int numberOfsquares = 0; 
           for (int i = 0; i <= number; i++)
            {
                numberOfsquares += i * i;
            }
            return numberOfsquares; 
        }
    }
}
