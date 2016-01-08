/*Masa de prânz
Tu și prietenul tău vă întâlniți întâmplător la restaurant. În timpul mesei de prânz din 
discuția avută cu el, afli că el ia prânzul la acel restaurant din 4 în 4 zile. Când te 
vei întâlni din nou cu el, dacă tu iei prânzul la restaurantul respectiv odată la 6 zile?*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class LunchTests
    {
        [TestMethod]
        public void DaysUntilNextMeetingForDays2and4()
        {
            Assert.AreEqual(4, GetNumberOfDaysUntilTheNextLunchMeeting(2, 4));
        }
        [TestMethod]
        public void DaysUntilNextMeetingForDays4and6()
        {
            Assert.AreEqual(12, GetNumberOfDaysUntilTheNextLunchMeeting(4, 6));
        }

        int  GetNumberOfDaysUntilTheNextLunchMeeting(int hisDay, int myDay)
        {
            int a; int b;
            if (myDay > hisDay)
            {
               a = myDay; b =hisDay;
            }
            else
            {
                a = hisDay; b = myDay;
            }

            for (int i = 1; i <= b; i++)
            {
                if ((a * i) % b == 0)
                {
                    return i * a;
                }
            }
            return b;
         }
    }
}
