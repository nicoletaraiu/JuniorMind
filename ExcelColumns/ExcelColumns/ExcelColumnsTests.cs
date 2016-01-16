/*Coloane excel
Primele 26 de coloane din Excel sunt marcate cu literele alfabetului. După care continuă cu combinații
de câte două litere, astfel coloana 27 este AA, 28 - AB, iar coloana 52 cu AZ. După ZZ, se continuă cu 
combinații de 3 litere.

Dacă se dă numărul coloanei află care e combinația de litere corespunzătoare.*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class ExcelColumnsTests
    {
        [TestMethod]
        public void TestForFirstColumn()
        {
            Assert.AreEqual("a", GetColumnName(1)); 
        }

        [TestMethod]
        public void TestFor27Column()
        {
            Assert.AreEqual("aa", GetColumnName(27));
        }


        string GetChar(int number)
        {

            return Convert.ToChar('a' + number - 1).ToString();


        }

        string GetColumnName(int columnNumber)
        {
            if (columnNumber > 26)
            {
                return GetChar(columnNumber / 26) + GetChar(columnNumber % 26);
            }
            else
                return GetChar(columnNumber);
        }

        

        
    }
}
