using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var tw = new TimeWatch();
            Console.Write("スタート？");
            Console.ReadLine();

            tw.Start();

            //Thread.Sleep(1000);

            Console.Write("ストップ？");
            Console.ReadLine();
            
            TimeSpan duration = tw.Stop();
            Console.WriteLine("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);
        }
    }

    class TimeWatch {
        private DateTime start;
        public void Start() {
            start = DateTime.Now;
        }

        public TimeSpan Stop() {
            var stop = DateTime.Now;
            return stop - start;

            //模範
            //return DateTime.Now - start;

        }
    }
}
