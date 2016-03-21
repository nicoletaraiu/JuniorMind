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
        public void TestMethod1()
        {
            
        }

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


        struct firstAlarm
        {
            DaysOfTheWeek days;
            int hour; 
             
        }
       /* static DaysOfTheWeek firstAlarm(DaysOfTheWeek days, out int hour)
        {
            hour = 8;
            return days | DaysOfTheWeek.Monday | DaysOfTheWeek.Tuesday| DaysOfTheWeek.Wednesday 
                | DaysOfTheWeek.Thursday | DaysOfTheWeek.Friday;
            
        }

        static DaysOfTheWeek secondAlarm(DaysOfTheWeek days, out int hour)
        {
            hour = 10;
            return days | DaysOfTheWeek.Saturday | DaysOfTheWeek.Sunday;*/
        }

        static checkWhatAlarmRings

    }
}
