/*Alarmă
O alarmă poate fi setată să se declanșeze la o anumită oră în una sau în mai multe zile din săptămână.
De exemplu, se poate configura ca alarma să se declanșeze la ora 6 de luni până vineri și să se declanșeze la ora 8 sâmbătă și duminică.
Scrie o funcție care decide pe baza acestor setări dacă trebuie declanșată alarma într-o anumită zi la o anumită oră.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class AlarmTests
    {
        [TestMethod]
        public void TestWhichAlarmWillRing()
        {  
            Alarm[] alarms = {
                new Alarm { day = DaysOfTheWeek.Monday | DaysOfTheWeek.Tuesday | DaysOfTheWeek.Wednesday | DaysOfTheWeek.Thursday | DaysOfTheWeek.Friday, hour = 7 },
                new Alarm { day = DaysOfTheWeek.Saturday | DaysOfTheWeek.Sunday, hour = 9 }
            };

            Alarm willRingOnWeekend = alarms[1];
            Alarm willRingOnWeekDays = alarms[0];
            Alarm willNotRing = new Alarm { day = DaysOfTheWeek.Monday, hour = -1 };
            Assert.AreEqual(true, GiveTheAlarms(alarms, DaysOfTheWeek.Sunday, 9, out willRingOnWeekend));
            Assert.AreEqual(true, GiveTheAlarms(alarms, DaysOfTheWeek.Wednesday, 7, out willRingOnWeekDays));
            Assert.AreEqual(false, GiveTheAlarms(alarms, DaysOfTheWeek.Tuesday, 11, out willNotRing));
        }

        [Flags]
        enum DaysOfTheWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }


        struct Alarm
        {
           public DaysOfTheWeek day;
           public  int hour;
            public Alarm(DaysOfTheWeek day, int hour)
            {
                this.day = day;
                this.hour = hour;
            }


        }


        static bool GiveTheAlarms(Alarm[] alarmsSet, DaysOfTheWeek currentDay, int currentHour, out Alarm alarmThatWillRing)
        {
            alarmThatWillRing = new Alarm(DaysOfTheWeek.Monday, -1);
            for (int i = 0; i < alarmsSet.Length; i++)
            {
                if (((currentDay & alarmsSet[i].day) != 0) && (alarmsSet[i].hour == currentHour))
                {
                    alarmThatWillRing = alarmsSet[i];
                    return true;
                }
            }
                    return false;
            
        }
  
    }
}
