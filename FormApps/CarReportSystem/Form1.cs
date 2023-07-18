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
            stasLabelDisp("");
            if (cbAuthor.Text == "") {
                stasLabelDisp("記録者入力して");
                return;
                //MessageBox.Show("入力して");
            }
            else if (cbCarName.Text == "") {
                stasLabelDisp("車名入力して");
                return;
            }
            
                var Car = new CarReport {

                    Date = dtpDate.Value,
                    Author = cbAuthor.Text,
                    Maker = getSelectedMaker(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    CarImage = pbCarImage.Image,
                };
                CarReports.Add(Car);
                if (!cbAuthor.Items.Contains(cbAuthor.Text)) {
                    cbAuthor.Items.Add(cbAuthor.Text);
                }
                if (!cbCarName.Items.Contains(cbCarName.Text)) {
                    cbCarName.Items.Add(cbCarName.Text);
                }
                
                dgvCarReports.ClearSelection();
                clear();

            
 
        }
        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked)
                  return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
               
            }
            return CarReport.MakerGroup.その他;

            //if (rbToyota.Checked)
            //    return CarReport.MakerGroup.トヨタ;
            //if(rbNissan.Checked)
            //    return CarReport.MakerGroup.日産;
            //if(rbHonda.Checked)
            //    return CarReport.MakerGroup.ホンダ;
            //if(rbImported.Checked)
            //    return CarReport.MakerGroup.輸入車;
            //if(rbSubaru.Checked)
            //    return CarReport.MakerGroup.スバル;
            //if(rbSuzuki.Checked)
            //    return CarReport.MakerGroup.スズキ;
            //if(rbDaihatsu.Checked)
            //    return CarReport.MakerGroup.ダイハツ;
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }

        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            CarReports.Remove(CarReports[dgvCarReports.CurrentCell.RowIndex]);
            clear();
            //CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            if (CarReports.Count == 0) {
                btModifyReport.Enabled = false;
                btDeleteReport.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;
            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;
        }

        private void cellcrick(object sender, DataGridViewCellEventArgs e) {
            if (CarReports.Count != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
                btModifyReport.Enabled = true;
                btDeleteReport.Enabled = true;
            }
            
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            stasLabelDisp("");
            if (cbAuthor.Text == "") {
                stasLabelDisp("記録者入力して");
                return;
                //MessageBox.Show("入力して");
            }
            else if (cbCarName.Text == "") {
                stasLabelDisp("車名入力して");
                return;
            }
            CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
            CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
            CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
            CarReports[dgvCarReports.CurrentRow.Index].CarImage = pbCarImage.Image;
            dgvCarReports.Refresh();
        }

        private void clear() {
            cbAuthor.Text = "";
            rbToyota.Checked = true;
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;

        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //ステータスラベルのテキスト
        private void stasLabelDisp(string msg) {
            tsInfoText.Text = msg;
        }

        private void 色設定ToolStripMenuItem1_Click(object sender, EventArgs e) {
            cdColor.ShowDialog();
            this.BackColor = cdColor.Color;
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイアログとして表示
        }
    }
}
