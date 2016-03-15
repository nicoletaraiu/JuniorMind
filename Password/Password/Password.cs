/*Parolă
Scrie o funcție care generează o parolă de până la X caractere.
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
    public class Password
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [Flags]
        enum PasswordOptions
        {
            smallLetters = 1,
            capitalLetters = 2,
            symbols = 4,
            noSimillars = 8,
            noAmbiguous = 16
        }
    }
}
