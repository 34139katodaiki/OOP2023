using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //メートル単位を表すクラス
    public class GramUnit : WeightUnit {
        private static List<GramUnit> units = new List<GramUnit> {
            new GramUnit{Name = "グラム",Coefficient =1,},
            new GramUnit{Name = "キログラム",Coefficient =1000,},
        };
        public static ICollection<GramUnit> Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変換
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns>メートル単位</returns>
        public double FromOunceUnit(OunceUnit unit,double value) {
            return (value * unit.Coefficient) * 28.35 / this.Coefficient;
        }
    }
}
