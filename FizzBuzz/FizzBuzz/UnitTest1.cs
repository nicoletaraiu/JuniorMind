/*Pentru un număr dat dacă e multiplu de 3 rezultatul trebuie să fie Fizz iar dacă
e multiplu de 5 rezultatul trebuie să fie Buzz. Dacă e multiplu de 3 și de 5 rezultatul
trebuie să fie FizzBuzz.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestMultipleOf3()
        {
           string multipleOf3 = multiple(12); 
            Assert.AreEqual("Fizz", multipleOf3);
        }
        [TestMethod]
        public void TestMultipleOf5()
        {
            string multipleOf5 = multiple(25);
            Assert.AreEqual("Buzz", multipleOf5);
        }
        [TestMethod]     
        public void TestMultipleOf3and5()
        {
            string multipleOf3and5 = multiple(15);
            Assert.AreEqual("FizzBuzz", multipleOf3and5);
        }   

        string multiple(int numar) {
          string msg= "";
            if ((numar % 3 == 0) && (numar % 5 == 0))
                msg = "FizzBuzz";
            else 
            if (numar % 3 == 0)
                msg = "Fizz";
            else
            if (numar % 5 == 0)
                msg = "Buzz";
            return msg; 
        }
    }
}
