using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double gramValue, ounceValue;

        public double GramValue {
            get { return this.gramValue; }
            set {
                this.gramValue = value;
                this.OnPropertyChanged();
            }
        }

        public double OunceValue {
            get { return this.ounceValue; }
            set {
                this.ounceValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値（単位）
        public GramUnit CurrentGramUnit { get; set; }

        //下のComboBoxで選択されている値（単位）
        public OunceUnit CurrentOunceUnit { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand OunceUnitToGram { get; private set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand GramUnitToOunceUnit { get; private set; }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentGramUnit = GramUnit.Units.First();
            this.CurrentOunceUnit = OunceUnit.Units.First();

            this.GramUnitToOunceUnit = new DelegateCommand(
                () => this.OunceValue = this.CurrentOunceUnit.FromGramUnit(
                    this.CurrentGramUnit, this.GramValue));

            this.OunceUnitToGram = new DelegateCommand(
                () => this.GramValue = this.CurrentGramUnit.FromOunceUnit(
                    this.CurrentOunceUnit, this.OunceValue));
        }

    }
}
