using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            
            var days =DateTime.Now - dtpDate.Value;
            tbMessage.Text ="入力した日にちから"+ days.Days.ToString()+"日";
        }

        private void btbeforeyear_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddYears(-1);
            tbMessage.Text = dtpDate.Value.ToString("D");
        }

        private void btnextyear_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddYears(1);
            tbMessage.Text = dtpDate.Value.ToString("D");
        }

        private void btbeforemonth_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddMonths(-1);
            tbMessage.Text = dtpDate.Value.ToString("D");
        }

        private void btnextmonth_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddMonths(1);
            tbMessage.Text = dtpDate.Value.ToString("D");
        }

        private void btbeforeday_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddDays(-1);
            tbMessage.Text = dtpDate.Value.ToString("D");
        }

        private void btnextday_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddDays(1);
            tbMessage.Text = dtpDate.Value.ToString("D");
        }

        private void Form1_Load(object sender, EventArgs e) {
            tbnowtime.Text = DateTime.Now.ToString("yyyy年MM月H時mm分ss秒");
            tmTimeDisp.Start();
        }

        private void btAge_Click(object sender, EventArgs e) {
            var age = DateTime.Today.Year - dtpDate.Value.Year;
            if(DateTime.Today < dtpDate.Value.AddYears(age)) {
                age--;
            }
            tbMessage.Text = age + "歳";
        }

        //タイマーイベントハンドラー
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbnowtime.Text = DateTime.Now.ToString("yyyy年MM月H時mm分ss秒");
        }
    }
}
