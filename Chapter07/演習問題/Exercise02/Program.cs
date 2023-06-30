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
            Console.WriteLine();

            //7.2.3
            if (abbrs.Remove("NPT"))
                Console.WriteLine(abbrs.Count);
            if (!abbrs.Remove("NPT"))
                Console.WriteLine("削除できません");
            Console.WriteLine();

            //7.2.4
            foreach (var item in abbrs.Where(x => x.Key.Length == 3)) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }

        }
    }
}
