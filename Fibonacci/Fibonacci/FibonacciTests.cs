/*Fibonacci
Calculează recursiv al k-lea număr din șirul Fibonacci.
Șirul Fibonacii este o serie de numere: 0, 1, 1, 2, 3, 5, 8, 13, 21, ...*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void EightFibonacciNumberTest()
        {
            Assert.AreEqual(21, Fibonacci(8));
        }

        public int Fibonacci(int k)
        {
            int previous = 0;
            return Fibonacci(k, ref previous);
        }
        public int Fibonacci(int k, ref int previous)
        {
            if (k < 2) return k;
            int beforePrevious = 0;
            previous = Fibonacci(k - 1, ref beforePrevious);
            return previous + beforePrevious;
        }
    }
}
