using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        private Timer moveTimer;    //タイマー用
        private PictureBox pbbar;
        private Obj ballobj;
        Bar Bar;
        private List<Obj> balls = new List<Obj>();    //ボールインスタンス格納
        private List<PictureBox> pbs = new List<PictureBox>();      //表示用

        

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {

            //this.Width = 1200;  //幅プロパティ
            //this.Height = 800;  //高さプロパティ
            this.Size = new Size(800, 600);
            this.BackColor = Color.Green;
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            //バー
            Bar = new Bar(340, 500);
            pbbar = new PictureBox();
            pbbar.Image = Bar.Image;
            pbbar.Location = new Point((int)Bar.PosX, (int)Bar.PosY);
            pbbar.Size = new Size(150, 10);
            pbbar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbbar.Parent = this;
            


            moveTimer = new Timer();
            moveTimer.Interval = 1; //タイマーのインターバル(ms)
            
            moveTimer.Tick += MoveTimer_Tick;   //デリゲート登録
        }

        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            Bar.Move(e.KeyData);
            pbbar.Location = new Point((int)Bar.PosX, (int)Bar.PosY);
        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            PictureBox pb = new PictureBox();
            
            if (e.Button == MouseButtons.Left)  //左
            {
                //ボールインスタンス生成
                ballobj = new SoccerBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(50, 50);
                
                
            }
            else if(e.Button==MouseButtons.Right)    //右
            {
                ballobj = new TennisBall(e.X-15, e.Y-15);
                pb.Size = new Size(30, 30);
                
            }

            pb.Image = ballobj.Image;
            pb.Location = new Point((int)ballobj.PosX, (int)ballobj.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            balls.Add(ballobj);
            pbs.Add(pb);
            this.Text = "サッカーボール:" +SoccerBall.Count  +"テニスボール:"+TennisBall.Count;
            moveTimer.Start();  //タイマースタート
        }
            //タイマータイムアウト時のイベントハンドラ 
            private void MoveTimer_Tick(object sender, EventArgs e) {
            
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move(pbbar,pbs[i]);  // 移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
                
            }
        }
    }
}
