using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise2_1(names);
            Console.WriteLine();
            Exercise2_2(names);
            Console.WriteLine();
            Exercise2_3(names);
            Console.WriteLine();
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力");
            do {
                var line = Console.ReadLine();

                if (string.IsNullOrEmpty(line)) {
                    break;
                }
                else {
                    var num = names.FindIndex(s => s == line);
                    Console.WriteLine(num);
                }
                
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            var num = names.Count(s => s.Contains('o'));
            Console.WriteLine(num);

            
        }

        private static void Exercise2_3(List<string> names) {
            var cities = names.Where(s => s.Contains('o')).ToArray();
            foreach (var city in cities) {
                Console.WriteLine(city);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var num = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var item in num) {
                Console.WriteLine(item);
            }

            //var selected = names.Where(s => s.StartsWith("B")).Select(s => new { s, s.Length });
            //foreach (var item in selected) {
            //    Console.WriteLine(item);
            //}
           
        }
    }
}
