using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");
            var filename = "sample.txt";
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.GetEncoding("Shift_JIS"))) {
                foreach (var line in lines) {
                    var replaced = Regex.Replace(line, @"(V|v)ersion=""v4.0""", @"version=""v5.0""");
                    sw.WriteLine(replaced);
                }
            }
            





            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}
