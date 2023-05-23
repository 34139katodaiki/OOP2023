using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {


        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4, 4, 2, 6, 8, 5, 13, 15 };

            var sum = numbers.Where(n => n % 2 == 0).Sum();
            //int count = numbers.Count(n => n % 5 == 0);
            Console.WriteLine(sum);
        }



    }
}
