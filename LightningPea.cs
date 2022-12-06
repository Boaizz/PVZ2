using SplashKitSDK;

namespace CustomProgram
{
    class LightningPea : Bullet
    {
        public LightningPea(ShooterPlant shooter) :base("Electric Pea", "lightningpea.png")
        {
            X = shooter.X + 25;
            Y = shooter.Y - 40;
            Damage = 15;
            SplashKit.SpriteSetVelocity(this.Sprite, Vel);
            SplashKit.SpriteSetX(this.Sprite, (float)X);
            SplashKit.SpriteSetY(this.Sprite, (float)Y);
        }
    }
}
