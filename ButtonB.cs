using System;
using SplashKitSDK;

namespace CustomProgram
{
    public class ButtonB : Button
    {
        public ButtonB() :base("ButtonB1", "buttonB1.png", 630,500)
        {
            SplashKit.SpriteAddLayer(this.Sprite, new Bitmap("ButtonB2", "buttonB2.png"), "On Hover");
            SplashKit.SpriteAddLayer(this.Sprite, new Bitmap("ButtonB3", "buttonB3.png"), "On Click");
        }
    }
}
