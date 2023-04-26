﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {


        public Bar(double xp ,double yp ):base(xp,yp, @"pic\bar.png") {

            MoveX = 30;
            MoveY = 0;

        }


        public override void Move() {
            //空のメソッド
            
        }
        public void Move(Keys directuon) {

            if (directuon==Keys.Right)
            {
                if (PosX<630)
                {
                    PosX += 20;
                }
                
            }
            else
            {
                if (PosX>0)
                {
                    PosX -= 20;
                }
                
            }
            
        }
        
    }
}
