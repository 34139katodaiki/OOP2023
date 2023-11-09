using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //ヤード単位を表すクラス
    public class OunceUnit : WeightUnit{
        private static List<OunceUnit> units = new List<OunceUnit> {
            new OunceUnit{Name = "オンス",Coefficient =1,},
            new OunceUnit{Name = "ポンド",Coefficient =16,},
            new OunceUnit{Name = "ストーン",Coefficient =16*14,},
        };
        public static ICollection<OunceUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns>変換値</returns>
        public double FromGramUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient) / 28.35 / this.Coefficient;
        }
    }
}
