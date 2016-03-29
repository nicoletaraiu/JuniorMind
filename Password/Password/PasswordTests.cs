﻿/*Scrie o funcție care generează o parolă de până la X caractere.
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
            var options = new PasswordOptions(13, 3, 2, 4, false, false);
            
            string pass = GeneratePassword(options);
            Assert.AreEqual(3, CheckNumber(pass, 'A', 'Z'));
            Assert.AreEqual(2, CheckNumber(pass, '0', '9'));
            Assert.AreEqual(4, CheckNumber(pass, 'a', 'z'));
            Assert.AreEqual(4, CheckNumberOfSymbols(pass));

        }

        [TestMethod]
        public void GenerateLettersOrDigitsWithoutSimilarsTest()
        {
            string pass = GenerateLettersOrDigits('l', 'm' + 1, 2, true);
            Assert.AreEqual("mm", pass); 
        }

        struct PasswordOptions
        {
            public int passwordLength;
            public int numberOfUpperCaseLetters;
            public int numberOfDigits;
            public int numberOfSymbols;
            public bool noSimilars;
            public bool noAmbiguous;

            public PasswordOptions(int passwordLength, int numberOfUpperCaseLetters, int numberOfDigits, int numberOfSymbols, bool noSimilars, bool noAmbiguous)
            {
                this.passwordLength = passwordLength;
                this.numberOfUpperCaseLetters = numberOfUpperCaseLetters;
                this.numberOfDigits = numberOfDigits;
                this.numberOfSymbols = numberOfSymbols;
                this.noSimilars = noSimilars;
                this.noAmbiguous = noAmbiguous;
               
            }

        }

        static string GenerateLettersOrDigits(int lowerLimit, int upperLimit, int length, bool excludeSimilars)
        {
            string password = null;
            Random rnd = new Random();
            string excluded = "l1Io0O";


            for (int i = 0; i < length; i++)
            {
                char ch = (char)rnd.Next(lowerLimit, upperLimit);
                if (excludeSimilars)
                    while (excluded.IndexOf(ch) != -1)
                    {
                        ch = (char)rnd.Next(lowerLimit, upperLimit);
                    }
            
                    password += ch.ToString();
                }

            return password; 
        }


        static string GenerateSymbols(int number)
        {
            string symbols = "!@#$%^&*()_\\-+={}[]:;'\"|,./<>?~";
            string generatedSymbols = null;
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
             generatedSymbols += symbols[rnd.Next(0, symbols.Length)];
            
            return generatedSymbols;   
            

        }

        static string GeneratePassword(PasswordOptions options)
        {  
            int numberOfLowerCase = options.passwordLength - options.numberOfUpperCaseLetters
                  - options.numberOfDigits - options.numberOfSymbols;
            string password = GenerateLettersOrDigits('A', 'Z' + 1, options.numberOfUpperCaseLetters, options.noSimilars)
                + GenerateLettersOrDigits('0', '9' + 1, options.numberOfDigits, options.noSimilars)
                + GenerateLettersOrDigits('a', 'z' + 1, numberOfLowerCase, options.noSimilars)
                + GenerateSymbols(options.numberOfSymbols);
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
        int CheckNumberOfSymbols(string password)
        {
            string symbols = "!@#$%^&*()_\\-+={}[]:;'\"|,./<>?~";
          
            int number = 0;
            for (int i = 0; i < password.Length; i++)
                if (symbols.IndexOf(password[i]) != - 1)
                    number++;
            return number;
        }

        
    }
}
