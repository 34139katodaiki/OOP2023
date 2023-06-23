using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Dict = new Dictionary<string, CityInfo>();
            //string city;
            //int population

            Console.Write("県名：");
            var ken = Console.ReadLine();
            
            while(ken!="999" ){
                var cityinfo = new CityInfo();
                Console.Write("所在地：");
                cityinfo.City= Console.ReadLine();
                
                Console.Write("人口：");
                cityinfo.Population = int.Parse(Console.ReadLine());
                

                Dict[ken] = cityinfo;


                //模範
                //Console.Write("所在地：");
                //city = Console.ReadLine();

                //Console.Write("人口：");
                //Population = int.Parse(Console.ReadLine());

                //Dict[ken] = new CityInfo {
                //    City = city;
                //    Population = population;
                //};


                Console.Write("県名：");
                ken = Console.ReadLine();

                if (Dict.ContainsKey(ken)) {
                    Console.WriteLine("同じキーが存在します、書き換えますか？(y/n)");
                    if (Console.ReadLine() == "n") {
                        Console.Write("県名：");
                        ken = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("1：一覧表示、2：件名指定");
            var hyouji = Console.ReadLine();
            if (hyouji =="1") {
                var sorted = Dict.OrderByDescending(x => x.Value.Population);
                foreach (var item in sorted) {
                    Console.WriteLine(item.Key + "[" + item.Value.City +"(人口："+item.Value.Population+ ")"+"]");
                }
            }
            else {
                Console.Write("県名を入力：");
                var pre = Console.ReadLine();
                Console.WriteLine(Dict[pre].City+"人口："+Dict[pre].Population);
            }
        }
    }

    class CityInfo {

        public string City { get; set; }
        public int Population { get; set; }
        
    }
}
