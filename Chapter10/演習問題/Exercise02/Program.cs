using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Pickup3DigitNumber("sample.txt");
        }

        private static void Pickup3DigitNumber(string file) {
            foreach (var line in File.ReadLines(file)) {
                var match = Regex.Matches(line, @"\b(\d{3,})\b");
                foreach (Match match1 in match) {
                    Console.WriteLine(match1.Value);
                }


            }
        }
    }
}