using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            //{\rtf1}
        }

        private static void Exercise3_1(string text) {
            var num = text.Count(s => s ==' ');
            Console.WriteLine("空白数:"+num);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            var num = text.Split(' ').Length;
            Console.WriteLine("単語数"+num);
        }

        private static void Exercise3_4(string text) {
            var st = text.Split(' ');
            foreach (var item in st) {
                if(item.Length < 5 ) {
                    Console.WriteLine(item);
                }
            }
        }

        private static void Exercise3_5(string text) {
            var st = text.Split(' ');
            var sb = new StringBuilder();
            foreach (var item in st) {
                sb.Append(item+' ');
            }
            var str = sb.ToString();
            Console.WriteLine(str);
        }
    }
}
