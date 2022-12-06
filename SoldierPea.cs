using SplashKitSDK;

namespace CustomProgram
{
    public class SoldierPea : ShooterPlant
    {
        public SoldierPea(double x, double y) :base("SoldierPea", "soldierpea1.png")
        {
            X = x;
            Y = y;
            Health = 100;
            SplashKit.SpriteSetX(this.Sprite, (float)X - 20);
            SplashKit.SpriteSetY(this.Sprite, (float)Y - 40);
        }


        public override void Shoot()
        {
            base.Shoot();
            this.BulletPeas.Add(new GreenPea(this.X, this.Y));
            this.BulletPeas.Add(new GreenPea(this.X + 40, this.Y));
            this.BulletPeas.Add(new GreenPea(this.X + 80, this.Y));
            this.BulletPeas.Add(new GreenPea(this.X + 120, this.Y));
        }
    }


}
