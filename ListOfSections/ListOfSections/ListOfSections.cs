/*Intersecție
Ți se dă o listă de tronsoane verticale și orizontale consecutive de dimensiuni fixe.
Scrie o funcție care verifică dacă tronsoanele se intersectează.Dacă se intersectează întoarce primul punct de intersecție.
Notă: având în vedere că tronsoanele sunt de dimensiuni fixe, alege cel mai simplu mod de a le reprezenta, de ex: ca și o succesiune de direcții stânga, dreapta, sus, jos.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListOfSections
{
    [TestClass]
    public class ListOfSections
    {
        [TestMethod]
        public void TestGetNextPoint()
        {
            var initialPoint = new Point(7, 4);
            var PointUp = new Point(7, 8);
            var PointDown = new Point(7, 0);
            var PointLeft = new Point(3, 4);
            var PointRight = new Point(11, 4);
            Assert.AreEqual(PointUp, GetNextPoint(initialPoint, Directions.up, 4));
            Assert.AreEqual(PointDown, GetNextPoint(initialPoint, Directions.down, 4));
            Assert.AreEqual(PointRight, GetNextPoint(initialPoint, Directions.right, 4));
            Assert.AreEqual(PointLeft, GetNextPoint(initialPoint, Directions.left, 4));
        }

        [TestMethod]
        public void CheckForIntersectionTest()
        {
            var intersectionPoint = new Point(2, 2);
            var NoIntersectionPoint = new Point(-1, -1);
            var anotherIntersectionPoint = new Point(5, 0);
            var originPoint = new Point(0, 0);
            Assert.AreEqual(true, CheckForIntersection(new Directions[] {Directions.up, Directions.right, Directions.up, Directions.down }, 2, out intersectionPoint));
            Assert.AreEqual(false, CheckForIntersection(new Directions[] { Directions.up, Directions.right, Directions.up, Directions.right }, 2, out NoIntersectionPoint));
            Assert.AreEqual(true, CheckForIntersection(new Directions[] { Directions.right, Directions.up, Directions.right, Directions.down, Directions.left }, 5, out anotherIntersectionPoint));
            Assert.AreEqual(true, CheckForIntersection(new Directions[] { Directions.up, Directions.down }, 2, out originPoint));

        }

        enum Directions
        {
            up = 1,
            down,
            right,
            left,
            
        }

        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

            static Point GetNextPoint(Point initialPoint, Directions  direction, int length)
            {

            Point newPoint = initialPoint;
                if (direction.Equals(Directions.up))
                {
                    newPoint.y += length;
                    return newPoint;
                }
                
                    if (direction.Equals(Directions.down))
                {
                    newPoint.y -= length;
                    return newPoint;
                }
                if (direction.Equals(Directions.left))
                {
                    newPoint.x -= length;
                    return newPoint;
                }
                if (direction.Equals(Directions.right))
                {
                    newPoint.x += length;
                  return newPoint;
                }
                return newPoint;
            
            }
        static bool CheckForIntersection (Directions[] directions, int length, out Point intersectionPoint)
        {   

            Point initialPoint = new Point(0, 0);
            Point[] pointsTillNow = new Point[directions.Length + 1];
            intersectionPoint = new Point(-1, -1);
            
            pointsTillNow[0] = initialPoint;
            for (int i = 0; i < directions.Length; i++)
            {   

                Point nextPoint = GetNextPoint(initialPoint, directions[i], length);
                pointsTillNow[i+1] = nextPoint; 

                for(int j = 0; j < i + 1; j++) 
                {
                    if (pointsTillNow[j].Equals(pointsTillNow[i + 1]))
                    {
                        intersectionPoint = pointsTillNow[i + 1];
                        return true;
                    }
                        
                }
                initialPoint = nextPoint;
             }
            return false;
     
        }
        

        }
    }

