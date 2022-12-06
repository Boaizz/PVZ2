﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace CustomProgram
{
    public class ButtonDeselected : Button //this button is used for deselected the card
    {
        public ButtonDeselected() :base("Deselected Button", "buttonA3.png",1150, 250)
        { 
            SplashKit.SpriteAddLayer(this.Sprite, new Bitmap("Deselected Button 1", "buttonA2.png"), "On Hover");
            SplashKit.SpriteAddLayer(this.Sprite, new Bitmap("Deselected Button 2", "buttonA1.png"), "On Click");
        }

        public override void CheckButtonState()
        {
            base.CheckButtonState();
            if (this.IsClickedTime >= 15)
            {
                this.IsClickedTime = 0;
            }
        }
    }
}
