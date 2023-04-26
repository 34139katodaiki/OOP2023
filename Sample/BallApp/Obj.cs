using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    //抽象クラス
    abstract class Obj {

        private Image image;
        private double posX;    //x座標
        private double posY;    //y座標
        private double moveX;  //移動量(x方向)
        private double moveY;  //移動量(y方向)
        


        public Obj(double PosX, double PosY,string Path) {

            this.PosX = PosX;
            this.PosY = PosY;
            Image = Image.FromFile(Path);


            
        }
        public Image Image { get => image; set => image = value; }
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public double MoveY { get => moveY; set => moveY = value; }
        public double MoveX { get => moveX; set => moveX = value; }
        


        //抽象メソッド
        public abstract void Move();

        


    }
}
