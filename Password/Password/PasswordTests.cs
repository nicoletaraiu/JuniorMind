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
            var options = new PasswordOptions(9, 9, 0);
            string pass = GeneratePassword(options);
            Assert.AreEqual(9, CheckNumber(pass, 'A', 'Z'));

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
            string password = GenerateLettersOrDigits('A', 'Z' + 1, options.numberOfUpperCaseLetters);
               // + GenerateLettersOrDigits(48, 58, options.numberOfDigits)
               // + GenerateLettersOrDigits(97, 123, options.passwordLength);
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
