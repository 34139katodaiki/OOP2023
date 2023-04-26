using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall :Obj{
        //フィールド

        private static int count;

        Random r = new Random();

        

        //コンストラクタ
        public SoccerBall(double xp , double yp) : base(xp, yp, @"pic\soccer_ball.png"){
            
            
            int rndX = r.Next(-50, 50);
            MoveX = rndX != 0 ? rndX : 1;//乱数で移動量を設定
            int rndY = r.Next(-50, 50);
            MoveY = rndY != 0 ? rndY : 1; //乱数で移動量を設定
            Count++;
        }

        public static int Count { get => count; set => count = value; }





        //メソッド
        public override void Move() {
            if (PosY > 550 || PosY<0)
            {
                MoveY = -MoveY;
            }
            if (PosX > 750 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            
            PosX += MoveX;
            PosY += MoveY;
        }   
    }
}
