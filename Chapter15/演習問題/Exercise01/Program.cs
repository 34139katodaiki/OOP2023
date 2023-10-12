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
            var book = Library.Books.Max(x => x.Price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var books = Library.Books.GroupBy(x => x.PublishedYear);
            foreach (var book in books) {
                Console.WriteLine("{0} {1}",book.Key,book.Count());
            }
            
        }

        private static void Exercise1_4() {
            var group = Library.Books.GroupBy(x => x.PublishedYear).Select(y => y.OrderByDescending(a => a.Price)
            .OrderByDescending(b=>b.PublishedYear));
            foreach (var books in group) {
                foreach (var book in books) {
                    Console.WriteLine("{0} {1}円 {2}", book.PublishedYear, book.Price, book.Title);
                }
            }
        }

        private static void Exercise1_5() {
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
