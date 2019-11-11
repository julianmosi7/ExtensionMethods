using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensionMethods
    {
       public static string LastTwoCharakters(this string s)
       {
            return $"First: {s[0]}{s[1]} Last: {s[s.Length-2]}{s[s.Length-1]}";
       }

       public static DateTime Yesterday(this DateTime d)
       {
            return d.AddHours(-24);
       }

        public static int Fact(this int num)
        {
            int fact = num;
            for (int i = 1; i < num; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public static string ToUsefulString(this DateTime date)
        {
            TimeSpan span = date - DateTime.Now;

            if (date.SameDay(DateTime.Now.AddDays(-2)))
            {
                return $"Vorgestern {date.Hour}:{date.Minute}";
            }

            else if (date.SameDay(DateTime.Now.AddDays(2)))
            {
                return $"Übermorgen {date.Hour}:{date.Minute}";
            }

            else if (date.SameDay(DateTime.Now.AddDays(-1)))
            {
                return $"Gestern {date.Hour}:{date.Minute}";
            }

            else if (date.SameDay(DateTime.Now))
            {
                return $"Heute {date.Hour}:{date.Minute}";
            } 

            else if (date.SameDay(DateTime.Now.AddDays(1)))
            {
                return $"Morgen {date.Hour}:{date.Minute}";
            }

            else if (date.SameMoment(DateTime.Now))
            {
                return $"Jetzt";
            }

            else if(span.Hours < 4)
            {
                return $"vor {span.Hours} h {span.Minutes} min";
            }

            else if(span.Hours < -4)
            {
                return $"in {span.Hours} h {span.Minutes} min";
            }

            else
            {
                return $"{date.DayOfWeek} {date.Day}.{date.Month} {date.Hour}:{date.Minute}";
            }

        }

        public static bool SameDay(this DateTime date, DateTime date2)
        {
            return date2.Day == date.Day && date2.Month == date.Month && date2.Year == date.Year;
        }

        public static bool SameMoment(this DateTime date, DateTime date2)
        {
            return date2.Day == date.Day && date2.Month == date.Month && date2.Year == date.Year && date.Minute == date2.Minute;
        }

        /*private delegate bool f(double d);
        public static List<string> UseOnly(this f action)
        {

        }*/
    }
}
