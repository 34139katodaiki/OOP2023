using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private uint mode;

        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();


        public Form1() {
            InitializeComponent();
            //dgvCarReports.DataSource = CarReports;
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

            
            setcbCarname(cbCarName.Text);
            setcbAuther(cbAuthor.Text);
            
                
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
        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
            }

        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            if(ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
            
            
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
            
            dgvCarReports.Columns[6].Visible = false;
            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;
            //tsTimeDisp.Text=(DateTime.Now.ToString("HH時mm分ss秒"));
            tsInfo.Text = "";
            tmTime.Start();
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;  //奇数行の色変更

            //設定の逆シリアル化
            try {
                using (var reader = XmlReader.Create("Settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                
            }
            

        }

        private void cellcrick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCarReports.Rows.Count != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();
                pbCarImage.Image =ByteArrayToImage((byte[])dgvCarReports.CurrentRow.Cells[6].Value);

                btModifyReport.Enabled = true;
                btDeleteReport.Enabled = true;
            }
            
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[3].Value = getSelectedMaker();
            dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202316DataSet);
            
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
            if(cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }
            
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイアログとして表示
        }

        private void btScaleChange_Click(object sender, EventArgs e) {

            mode = mode < 4 ? ((mode==1)? 3 : ++mode) : 0; //AutoSize(2)を除外
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルのシリアル化
            using(var writer = XmlWriter.Create("Settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }


        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        private void time(object sender, EventArgs e) {
            tsTimeDisp.Text = DateTime.Now.ToString("HH時mm分ss秒");

        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdCarRepoSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, CarReports);

                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofdCarRepoOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化でバイナリ形式を取り込む
                    var bf = new BinaryFormatter();
                    using(FileStream fs = File.Open(ofdCarRepoOpen.FileName, FileMode.Open,FileAccess.Read)) {
                        CarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReports.DataSource = null;
                        dgvCarReports.DataSource = CarReports;
                        dgvCarReports.ClearSelection();
                        dgvCarReports.Columns[5].Visible = false;
                        cbCarName.Items.Clear();
                        cbAuthor.Items.Clear();
                        foreach (var report in CarReports) {
                            setcbAuther(report.Author);
                            setcbCarname(report.CarName);
                            
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void setcbCarname(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }
        private void setcbAuther(string auther) {
            if (!cbAuthor.Items.Contains(auther)) {
                cbAuthor.Items.Add(auther);
            }
        }


        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }



        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202316DataSet);

        }

        //接続ボタンイベントハンドラ
        private void btConnection_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202316DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202316DataSet.CarReportTable);
            dgvCarReports.ClearSelection();
        }
    }
}
