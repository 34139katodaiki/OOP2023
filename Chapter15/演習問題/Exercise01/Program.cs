using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var book = Library.Books.OrderByDescending(x => x.Price).First();
            Console.WriteLine("発行年:{0} カテゴリ:{1} 価格{2} :{3}",book.PublishedYear,book.CategoryId,book.Price,book.Title);
        }

        private static void Exercise1_3() {
            var books = Library.Books.GroupBy(x => x.PublishedYear).Select(g=>new { PublishedYear = g.Key,Count = g.Count() })
                .OrderBy(x=>x.PublishedYear);
            foreach (var book in books) {
                Console.WriteLine("{0} {1}冊",book.PublishedYear,book.Count);
            }
        }

        private static void Exercise1_4() {
            var group = Library.Books.OrderByDescending(x => x.PublishedYear).GroupBy(x => x.PublishedYear).Select(y => y.OrderByDescending(x => x.Price)
              .Join(Library.Categories, book => book.CategoryId, category => category.Id, (book, category) =>
                     new { Title = book.Title, Category = category.Name, PublishYear = book.PublishedYear, Price = book.Price }));
            foreach (var books in group) {
                foreach (var book in books) {
                    Console.WriteLine("{0} {1}円 {2} ({3})", book.PublishYear, book.Price, book.Title, book.Category);
                }
            }
        }

        private static void Exercise1_5() {
            var books = Library.Books.Where(x => x.PublishedYear == 2016)
                .Join(Library.Categories, book => book.CategoryId, category => category.Id,
                (book, category) => category.Name).Distinct();
            foreach (var book in books) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
