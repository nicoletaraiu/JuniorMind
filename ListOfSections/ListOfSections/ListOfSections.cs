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
            Assert.AreEqual(PointUp, GetNextPoint(initialPoint, 1, 4));
            Assert.AreEqual(PointDown, GetNextPoint(initialPoint, 2, 4));
            Assert.AreEqual(PointRight, GetNextPoint(initialPoint, 3, 4));
            Assert.AreEqual(PointLeft, GetNextPoint(initialPoint, 4, 4));
        }

        [TestMethod]
        public void CheckForIntersectionTest()
        {
            var intersectionPoint = new Point(2, 2);
            Assert.AreEqual(intersectionPoint, CheckForIntersection(new int[] {1, 3, 1, 2 }, 2));
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

            static Point GetNextPoint(Point initialPoint, int direction, int length)
            {

            Point newPoint = initialPoint;
                if (direction == (int)Directions.up)
                {
                    newPoint.y += length;
                    return newPoint;
                }
                
                    if (direction == (int)Directions.down)
                {
                    newPoint.y -= length;
                    return newPoint;
                }
                if (direction == (int)Directions.left)
                {
                    newPoint.x -= length;
                    return newPoint;
                }
                if (direction == (int)Directions.right)
                {
                    newPoint.x += length;
                  return newPoint;
                }
                return newPoint;
            
            }
        static Point CheckForIntersection (int[] directions, int length)
        {
            Point initialPoint = new Point(0, 0);
            Point[] pointsTillNow = new Point[directions.Length];
            
            pointsTillNow[0] = initialPoint;
            for (int i = 0; i < directions.Length; i++)
            {
                Point nextPoint = GetNextPoint(initialPoint, directions[i], length);
                pointsTillNow[i] = nextPoint; 

                for(int j = 0; j < i; j++)
                {
                    if (pointsTillNow[j].Equals(pointsTillNow[i]))
                        return pointsTillNow[i];
                }
                initialPoint = nextPoint;
             }
            return new Point(-1, -1);
        }
        

        }
    }

