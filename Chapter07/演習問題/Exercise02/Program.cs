using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var abbrs = new Abbreviations();
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //7.2.3
            Console.WriteLine(abbrs.Count);

            //7.2.3
            abbrs.Remove("IOC");
            Console.WriteLine(abbrs.Count);

            //7.2.4
            var threedi = abbrs.Where(x => x.Key.Length == 3);
            foreach (var item in threedi) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }

        }
    }
}
