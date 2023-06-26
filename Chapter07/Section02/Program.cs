using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            var Dict = new Dictionary<string, List<CityInfo>>();
            
            Console.WriteLine("都市の登録");

            Console.Write("県名：");
            var ken = Console.ReadLine();

            while (ken != "999") {
                var cityinfo = new CityInfo();

                Console.Write("都市：");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口：");
                cityinfo.Population = int.Parse(Console.ReadLine());

                if (Dict.ContainsKey(ken)) {
                    Dict[ken].Add(cityinfo);
                }
                else {
                    Dict[ken] = new List<CityInfo> {cityinfo};
                }

                Console.Write("県名：");
                ken = Console.ReadLine();
            }

            Console.WriteLine("1：一覧表示、2：件名指定");
            var hyouji = Console.ReadLine();
            if (hyouji == "1") {
                var sorted = Dict.Values.OrderByDescending(x => x);
                foreach (var items in Dict) {
                    foreach (var item in items.Value.OrderByDescending(x => x.Population)) {
                        Console.WriteLine(items.Key + "[" + item.City+ "(人口：" + item.Population + ")]"); 
                    }
                }
            }
            else {
                Console.Write("県名を入力：");
                var pre = Console.ReadLine();
                try {
                    foreach (var item in Dict[pre]) {
                        Console.WriteLine(pre + "[" + item.City + "(人口：" + item.Population + ")]");
                    }
                }
                catch (KeyNotFoundException) {
                    Console.WriteLine(pre + "は登録されてません");
                }
                
            }
        }
    }

    class CityInfo {

        public string City { get; set; }
        public int Population { get; set; }

    }
}

