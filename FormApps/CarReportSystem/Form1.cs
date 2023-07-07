using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //追加ボタンがクリックされたときのイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            var Car = new CarReport();
            Car.Date = dtpDate.Value;
            Car.Author = cbAuthor.Text;
            
            Car.CarName = cbCarName.Text;
            Car.Report = tbReport.Text;
            Car.CarImage = pbCarImage.Image;
            CarReports.Add(Car);
        }

        private CarReport.MakerGroup getSelectedMaker() {
            

            
            return CarReport.MakerGroup.トヨタ;
        }


    }
}
