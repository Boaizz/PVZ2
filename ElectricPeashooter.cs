using SplashKitSDK;

namespace CustomProgram
{
    class ElectricPeashooter : ShooterPlant
    {
        public ElectricPeashooter(double x, double y) : base("Electric Peashooter", "electricpea.png")
        {
            X = x;
            Y = y;
            Health = 100;
            SplashKit.SpriteSetX(this.Sprite, (float)X - 20);
            SplashKit.SpriteSetY(this.Sprite, (float)Y - 40);
        }

        public override void Shoot()
        {
            LightningPea lightningPea = new LightningPea(this);
            base.Shoot();
            this.BulletPeas.Add(lightningPea);
        }
    }
}
