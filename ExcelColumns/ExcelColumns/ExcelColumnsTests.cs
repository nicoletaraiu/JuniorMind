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
            Assert.AreEqual("A", GetColumnName(1)); 
        }

        [TestMethod]
        public void TestFor27Column()
        {
            Assert.AreEqual("AA", GetColumnName(27));
        }

        [TestMethod]
        public void TestFor28Column()
        {
            Assert.AreEqual("AB", GetColumnName(28));
        }
        [TestMethod]
        public void TestFor52Column()
        {
            Assert.AreEqual("AZ", GetColumnName(52));
        }


        string GetChar(int number)
        {

            return Convert.ToChar('A' + number).ToString();


        }

        string GetColumnName(int columnNumber)
        {
            string columnName = string.Empty;
            while (columnNumber > 0)
            {
                columnNumber--;
                columnName = GetChar(columnNumber % 26) + columnName;
                columnNumber /= 26; 
            }
            
                return columnName;
        }

    }
}
