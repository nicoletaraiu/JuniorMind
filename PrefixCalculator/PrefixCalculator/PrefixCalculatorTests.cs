/*Scrie un program care imită un calculator de buzunar în formă prefixată.
Operațiile posibile sunt:
adunare/scădere
înmulțire/împărțire
suportă numere reale
Notă: În forma prefixată operatorii apar înainte operanzilor.
Exemple pentru format prefixată:
* 3 4 e echivalent cu 3 * 4
* + 1 1 2, e echivalent cu (1 + 1) * 2
+ / * + 56 45 46 3 - 1 0.25 e echivalent cu ((56 + 45) * 46) / 3 + (1 - 0.25)*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrefixCalculator
{
    [TestClass]
    public class PrefixCalculatorTests
    {
        [TestMethod]
        public void SimplestTest()
        {
            string expression = "+ 1 2";
            int i = 0;
            Assert.AreEqual(3, GiveResult(SplitString (expression), ref i)); 
        }

        [TestMethod]
        public void SumAndMultiplicationTest()
        {
            int i = 0;
            string expression = "* + 1 1 2";
            Assert.AreEqual(4, GiveResult(SplitString(expression), ref i));

        }

        public double GiveResult(string[] expression, ref int i)
        {
           
            double operand;
            if (double.TryParse(expression[i++], out operand))
            {
                return operand;
            }
            if (expression[i].Equals('+'))
                return GiveResult(expression, ref i) * GiveResult(expression, ref i);
           
                return GiveResult(expression, ref i) + GiveResult(expression, ref i);


        }
        public string[] SplitString(string str)
        {
            return str.Split(' '); 
        }
    }
}
