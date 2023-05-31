using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("数字列:");
            var line = Console.ReadLine();
            int num;
            if(int.TryParse(line,out num)) {
                var s1 = string.Format("{0:#,0}", num);
                Console.WriteLine(s1);
            }
            else {
                Console.WriteLine("数値文字列ではありません");
            }
        }
    }
}
