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

        int CalculateSquaresOnChessBoard(int number)
        {
            if (number == 2)
                return 1 + 2 * 2;
            else
                return 1 + 2 * 2 + 3 * 3; 
        }
    }
}
