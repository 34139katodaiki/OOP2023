﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class TennisBall : Obj {

        private static int count;
        Random r = new Random();
        
        public TennisBall(double xp,double yp):base(xp,yp,@"pic\tennis_ball.png") {
            

            int rndX = r.Next(-50, 50);
            MoveX = rndX != 0 ? rndX : 1;//乱数で移動量を設定
            int rndY = r.Next(-50, 50);
            MoveY = rndY != 0 ? rndY : 1; //乱数で移動量を設定
            Count++;
        }

        public static int Count { get => count; set => count = value; }

        public override void Move() {

            if (PosY > 550 || PosY < 0)
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
