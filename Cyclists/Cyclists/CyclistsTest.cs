/*Ciclometrul
Un ciclometru e un mecanism simplu care numără rotațiile unei roți de bicicletă.
În urma unei curse ai datele înregistrate de ciclometrele bicicliștilor participanți.
Ciclometrul fiecărui participant a înregistrat numărul de rotații făcute în fiecare secundă.
Dacă cunoști pentru fiecare bicicletă diametrul roților:
Calculează distanța totală parcursă de toți bicicliștii
Găsește secunda și numele biciclistului care a atins viteza maximă
Găsește biciclistul care a avut cea mai bună viteză medie*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclists
{
    [TestClass]
    public class CyclistsTest
    {
        [TestMethod]
        public void DistancePerSecondTest()
        {
            Assert.AreEqual((decimal)376.8, CalculateDistancePerSecond(60, 2));
        }

        [TestMethod]
        public void CalculateTotalDistanceForACyclistTest()
        {
            var cyclist = new Cyclist("Sandra", new int[] { 1, 2, 2, 3 }, 60);
            Assert.AreEqual((decimal)1507.2, CalculateTotalDistanceForACyclist(cyclist));

        }

        [TestMethod]
        public void CalculateTotalDistanceTest()
        {
            var cyclists = new Cyclist[] { new Cyclist ("Sandra", new int[] { 1, 2, 2, 3 }, 60),
                          new Cyclist("Ion", new int[] { 1, 2, 3, 4 }, 65),
                          new Cyclist("Marian", new int[] { 1, 2, 2, 4 }, 66)
            };
            Assert.AreEqual((decimal)5413.36, CalculateTotalDistance(cyclists));
        }

        struct Cyclist
        {
            public string name;
            public int[] rotationsPerSecond;
            public int wheelDiameter; 

            public Cyclist(string name, int[] rotationsPerSecond, int wheelDiameter)
            {
                this.name = name;
                this.rotationsPerSecond = rotationsPerSecond;
                this.wheelDiameter = wheelDiameter;
            }
        }

        static decimal CalculateDistancePerSecond(int wheelDiameter, int rotationsPerSecond)
        {
            return (decimal)3.14 * wheelDiameter * rotationsPerSecond;

        }

        static decimal CalculateTotalDistanceForACyclist(Cyclist cyclist)
        {
            decimal distance = 0;
            for (int i = 0; i < cyclist.rotationsPerSecond.Length; i++)
                distance += CalculateDistancePerSecond(cyclist.wheelDiameter, cyclist.rotationsPerSecond[i]);
            return distance; 
        }
        static decimal CalculateTotalDistance(Cyclist[] cyclists)
        {
            decimal totalDistance = 0;
            for (int i = 0; i < cyclists.Length; i++)
               totalDistance += CalculateTotalDistanceForACyclist(cyclists[i]);
            return totalDistance;
             
        }

        
    }
}
