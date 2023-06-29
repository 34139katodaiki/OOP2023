using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();

            foreach (var item in text.ToUpper()) {
                if ('A' <= item && 'Z' >= item) {
                    if (dict.ContainsKey(item)) {
                        dict[item]++;
                    }
                    else {
                        dict.Add(item, 1);
                    }
                }
            }

            var sorted = dict.OrderBy(x => x.Key);
            foreach (var a in sorted) {
                Console.WriteLine("'{0}'：{1}", a.Key, a.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char, int>();
            foreach (var item in text.ToUpper()) {
                if ('A' <= item && 'Z' >= item) {
                    if (!dict.ContainsKey(item)) {
                        dict.Add(item, 1);
                    }
                    else {
                        dict[item]++;
                    }
                }
            }
            foreach (var a in dict) {
                Console.WriteLine("'{0}'：{1}", a.Key, a.Value);
            }
        }
    }
}
