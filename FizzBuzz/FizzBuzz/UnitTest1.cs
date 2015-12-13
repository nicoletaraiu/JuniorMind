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

        string multiple(int numar) {
            string msg= "";
            if (numar %2 == 0)
               msg = "Fizz";
            return msg; 
        }
    }
}
