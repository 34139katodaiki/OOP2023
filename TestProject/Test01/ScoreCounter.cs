using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);




        }


        //メソッドの概要： 点数データを読み込み、studentsオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines) {
                var person = line.Split(',');

                var student = new Student {
                    Name = person[0],
                    Subject = person[1],
                    Score = int.Parse(person[2])
                };
                students.Add(student);
            }
            return students;





            
        }

        //メソッドの概要： 科目別の点数合計を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new SortedDictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    dict[student.Subject] += student.Score;
                }
                else {
                    dict[student.Subject] = student.Score;
                }
                
            }
            return dict;




            
        }
    }
}
