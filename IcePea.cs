using SplashKitSDK;

namespace CustomProgram
{
    class IcePea : Bullet
    {
        public IcePea(ShooterPlant shooter) :base("Ice Pea", "peaice.png")
        {
            X = shooter.X + 25;
            Y = shooter.Y - 40;
            Damage = 10;
            SplashKit.SpriteSetVelocity(this.Sprite, Vel);
            SplashKit.SpriteSetX(this.Sprite, (float)X);
            SplashKit.SpriteSetY(this.Sprite, (float)Y);
        }
    }
}
