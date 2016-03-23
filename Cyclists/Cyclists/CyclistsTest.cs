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
            Assert.AreEqual(376.99, CalculateDistancePerSecond(60, 2), 1e-2);
        }

        [TestMethod]
        public void CalculateTotalDistanceForACyclistTest()
        {
            var cyclist = new Cyclist("Sandra", new int[] { 1, 2, 2, 3 }, 60);
            Assert.AreEqual((double)1507.96, CalculateTotalDistanceForACyclist(cyclist),1e-2);

        }

        [TestMethod]
        public void CalculateTotalDistanceTest()
        {
            var cyclists = new Cyclist[] { new Cyclist ("Sandra", new int[] { 1, 2, 2, 3 }, 60),
                          new Cyclist("Ion", new int[] { 1, 2, 3, 4 }, 65),
                          new Cyclist("Marian", new int[] { 1, 2, 2, 4 }, 66)
            };
            Assert.AreEqual(5416.10, CalculateTotalDistance(cyclists), 1e-2);
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

        static double CalculateDistancePerSecond(int wheelDiameter, int rotationsPerSecond)
        {
            return Math.PI * wheelDiameter * rotationsPerSecond;

        }

        static double CalculateTotalDistanceForACyclist(Cyclist cyclist)
        {
            double distance = 0;
            for (int i = 0; i < cyclist.rotationsPerSecond.Length; i++)
                distance += CalculateDistancePerSecond(cyclist.wheelDiameter, cyclist.rotationsPerSecond[i]);
            return distance; 
        }
        static double CalculateTotalDistance(Cyclist[] cyclists)
        {
            double totalDistance = 0;
            for (int i = 0; i < cyclists.Length; i++)
               totalDistance += CalculateTotalDistanceForACyclist(cyclists[i]);
            return totalDistance;
             
        }

        static double GiveSecondOfMaxSpeed(Cyclist cyclist)
        {
            int second = 0;
            return 0;
        }

        
    }
}
