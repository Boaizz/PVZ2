using System;
using SplashKitSDK;

namespace CustomProgram
{
    class GreenPea : Bullet
    {
        public GreenPea(double x, double y) : base("Green Pea", "pea.png")
        {
            X = x + 25;
            Y = y - 40;
            Damage = 10;
            SplashKit.SpriteSetVelocity(this.Sprite, Vel);
            SplashKit.SpriteSetX(this.Sprite, (float)X);
            SplashKit.SpriteSetY(this.Sprite, (float)Y);
        }
    }
}
