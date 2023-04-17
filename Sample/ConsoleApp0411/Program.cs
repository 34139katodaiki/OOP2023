using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {


            
            int[] enn =  { 10000, 5000, 1000, 500, 100, 50, 10, 5, 1 };

            Console.Write("金額:");
            int much = int.Parse(Console.ReadLine());
            Console.Write("支払:");
            int pay = int.Parse(Console.ReadLine());
            int change = pay - much;
            Console.WriteLine("お釣り:" + change);

            for(int i = 0; i < enn.Length; i++)
            {
                Console.Write(enn[i]+"円");
                wrast(change / enn[i]);
                change %= enn[i];
                
            }

        }

        private static void wrast (int change) {
            for(int i = 0; i < change; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
