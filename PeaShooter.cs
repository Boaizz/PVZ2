using SplashKitSDK;

namespace CustomProgram
{
    class PeaShooter : ShooterPlant
    {
        public PeaShooter(double x, double y) : base("Pea Shooter", "peashooter.png")
        {
            X = x;
            Y = y;
            Health = 100;
            SplashKit.SpriteSetX(this.Sprite,(float)X - 20);
            SplashKit.SpriteSetY(this.Sprite,(float)Y - 40);
        }

        public override void Shoot()
        {
            GreenPea greenPea = new GreenPea(this.X, this.Y);
            base.Shoot();
            this.BulletPeas.Add(greenPea);
        }
    }
}
