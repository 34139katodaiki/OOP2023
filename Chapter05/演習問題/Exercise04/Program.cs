#define Nonarray
//#define Stringarray
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {

#if Nonarray
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            var s = line.Split(';');
            var loveli = s[0].Split('=');
            var book = s[1].Split('=');
            var born = s[2].Split('=');
            Console.WriteLine("作者   : "+loveli[1]);
            Console.WriteLine("代表作 : "+book[1]);
            Console.WriteLine("誕生年 : "+born[1]);
#elif Stringarray
            string[] lines = {

            };
#endif

        }

    }
}
