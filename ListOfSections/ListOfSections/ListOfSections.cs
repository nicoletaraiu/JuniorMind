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

                Point newPoint = new Point(0,0);
                if (direction == (int)Directions.up)
                {
                    newPoint.x = initialPoint.x;
                    newPoint.y = initialPoint.y + length;
                    return newPoint;
                }
                
                    if (direction == (int)Directions.down)
                {
                    newPoint.x = initialPoint.x;
                    newPoint.y = initialPoint.y - length;
                    return newPoint;
                }
                if (direction == (int)Directions.left)
                {
                    newPoint.x = initialPoint.x - length;
                    newPoint.y = initialPoint.y;
                    return newPoint;
                }
                if (direction == (int)Directions.right)
                {
                    newPoint.x = initialPoint.x + length;
                    newPoint.y = initialPoint.y;
                    return newPoint;
                }
                return newPoint;


            }



        }
    }

