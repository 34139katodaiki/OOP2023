using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            DateTime date = DateTime.Today;
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {


                Console.WriteLine("{0}の次週の{1}: {2}",date.ToString("yy/MM/dd"), dayofweek,
                    NextWeek(date, (DayOfWeek)dayofweek).ToString("yy/MM/dd(ddd)"));
                
            }
        }
        public static DateTime NextWeek(DateTime date ,DayOfWeek dayofweek) {
            var days = (int)dayofweek - (int)date.DayOfWeek;
            if (days <= 0 || days < 7)
                days += 7;
            return date.AddDays(days);

            //模範
            //var nextweek = date.AddDays(7);
            //var days = (int)dayofweek - (int)date.DayOfWeek;
            //return nextweek.AddDays(days);
        }

    }
}
