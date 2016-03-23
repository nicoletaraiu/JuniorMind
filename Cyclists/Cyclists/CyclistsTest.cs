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

        [TestMethod]
        public void GiveSecondOfMaxSpeed()
        {
            var cyclist = new Cyclist("Sandra", new int[] { 1, 2, 2, 3 }, 60);
            Assert.AreEqual(4, GiveSecondOfMaxSpeed(cyclist));
        }

        [TestMethod]
        public void GiveNameAndSecondTest()
        {
            var cyclists = new Cyclist[] { new Cyclist ("Sandra", new int[] { 1, 2, 2, 3 }, 60),
                          new Cyclist("Ion", new int[] { 1, 2, 3, 4 }, 65),
                          new Cyclist("Marian", new int[] { 1, 2, 2, 4 }, 66)
            };
            int second = 4;
            Assert.AreEqual("Marian", GiveSecondAndName(cyclists, out second));
        }

        [TestMethod]
        public void GiveCyclistWithBestAverageSpeedTest()
        {
            var cyclists = new Cyclist[] { new Cyclist ("Sandra", new int[] { 1, 2, 2, 3 }, 60),
                          new Cyclist("Ion", new int[] { 1, 2, 3, 4 }, 65),
                          new Cyclist("Marian", new int[] { 1, 2, 2, 4 }, 66)
            };

            Assert.AreEqual("Ion", GiveCyclistWithBestAverageSpeed(cyclists));
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

        static int GiveSecondOfMaxSpeed(Cyclist cyclist)
        {
            int second = 0;
            for (int i = 0; i < cyclist.rotationsPerSecond.Length; i++)
                if (cyclist.rotationsPerSecond[i] > second)
                    second = i + 1;
            return second;
        }

        static string GiveSecondAndName(Cyclist[] cyclists, out int second)
        {
            double maxSpeed = 0;
            second = 0;
            int sec;
            double speed;
            string name = null;
            for (int i = 0; i< cyclists.Length; i++)
            {
                sec = GiveSecondOfMaxSpeed(cyclists[i]) - 1;
                speed = CalculateDistancePerSecond(cyclists[i].wheelDiameter, cyclists[i].rotationsPerSecond[sec]);
                if (speed > maxSpeed)
                {
                    maxSpeed = speed;
                    second = sec;
                    name = cyclists[i].name;
                } 
            }
            return name; 
        }

        static string GiveCyclistWithBestAverageSpeed(Cyclist[] cyclists)
        {
            string bestCyclist = null;
            double bestAvDistance = 0;
            for (int i = 0; i < cyclists.Length; i++)
            {
                int time = cyclists[i].rotationsPerSecond.Length;
                double currentAvDistance = CalculateTotalDistanceForACyclist(cyclists[i]) / time;
                if (currentAvDistance > bestAvDistance)
                {
                    bestAvDistance = currentAvDistance;
                    bestCyclist = cyclists[i].name;
                }
            }
            return bestCyclist;
        }
        
    }
}
