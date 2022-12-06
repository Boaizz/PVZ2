using SplashKitSDK;

namespace CustomProgram
{
    public class IcePeaShooter : ShooterPlant
    {
        public IcePeaShooter(double x, double y) :base("Snow Pea","snowpea.png")
        {
            X = x;
            Y = y;
            Health = 100;
            SplashKit.SpriteSetX(this.Sprite, (float)X - 20);
            SplashKit.SpriteSetY(this.Sprite, (float)Y - 40);
        }

        public override void Shoot() //shoot ice pea
        {
            IcePea icepea = new IcePea(this);
            base.Shoot();
            this.BulletPeas.Add(icepea);
        }
    }
}
