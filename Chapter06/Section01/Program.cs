using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 2, 5, 4, 0, 4, 1, 0, 4, };
            Console.WriteLine(numbers.Average());

            var books = Books.GetBooks();

            var booksobj = books.Where(x => x.Title.Contains("物語")).OrderByDescending(x => x.Price);
            foreach (var item in booksobj) {
                Console.WriteLine("{0}:{1}円", item.Title, item.Price);
            }

            Console.WriteLine();


            var bookave = books.Where(x => x.Title.Contains("物語")).Average(x => x.Price); 
            Console.WriteLine("平均:"+bookave);

            Console.WriteLine();

            var booklong = books.OrderByDescending(x => x.Title.Length);
            foreach (var book in booklong) {
                Console.WriteLine(book.Title);
            }

        }
    }
}
