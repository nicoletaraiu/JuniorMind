/*Scrie o funcție care generează o parolă de până la X caractere.
Funcția oferă ca și opțiuni:
litere mici
litere mari și numărul lor
cifre și numărul lor
simboluri și numărul lor
să nu includă caracterele similare: l, 1, I, o, 0, O
să nu includă caractere ambigue: {}[]()/\'"~,;.<>*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void CheckNumberTest()
        {
            var options = new PasswordOptions(9, 3, 2);
            string pass = GeneratePassword(options);
            Assert.AreEqual(3, CheckNumber(pass, 'A', 'Z'));
            Assert.AreEqual(2, CheckNumber(pass, '0', '9'));
            Assert.AreEqual(4, CheckNumber(pass, 'a', 'z'));

        }

        struct PasswordOptions
        {
            public int passwordLength;
            public int numberOfUpperCaseLetters;
            public int numberOfDigits;
             

            public PasswordOptions(int passwordLength, int numberOfUpperCaseLetters, int numberOfDigits)
            {
                this.passwordLength = passwordLength;
                this.numberOfUpperCaseLetters = numberOfUpperCaseLetters;
                this.numberOfDigits = numberOfDigits;
               
            }

        }

        static string GenerateLettersOrDigits(int lowerLimit, int upperLimit, int length)
        {
            string password = null;
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                char ch = (char)rnd.Next(lowerLimit, upperLimit);
                password += ch.ToString(); 
            }
            return password; 
        }

        static string GeneratePassword(PasswordOptions options)
        {
            int numberOfLowerCase = options.passwordLength - options.numberOfUpperCaseLetters
                  - options.numberOfDigits;
            string password = GenerateLettersOrDigits('A', 'Z' + 1, options.numberOfUpperCaseLetters)
                + GenerateLettersOrDigits('0', '9' + 1, options.numberOfDigits)
                + GenerateLettersOrDigits('a', 'z' + 1, numberOfLowerCase);
            return password;
        }

        int CheckNumber(string password, char start, char end)
        {
            int number = 0;
            for (int i = 0; i < password.Length; i++)
                if ((password[i] >= start) && password[i] <= end)
                    number++;
            return number; 
        }

    }
}
