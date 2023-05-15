using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {


        }

        //売上データを読み込み、saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();    //売上でーたを格納する
            string[] lines = File.ReadAllLines(filePath);   //ファイルからすべてのデータを読み込む
            
            foreach (string line in lines) {    //すべての行から1行ずつ取り出す
                string[] items = line.Split(',');   //区切りで項目別に分ける
                
                Sale sale = new Sale {  //saleインスタンス生成
                    
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);    //saleインスタンスをコレクションに追加
            }

            return sales;
        }

    }
}
