using SplashKitSDK;

namespace CustomProgram
{
    public class Repeater : ShooterPlant
    {
        public Repeater(double x, double y) :base("Repeater", "repeater.png")
        {
            X = x;
            Y = y;
            Health = 100;
            SplashKit.SpriteSetX(this.Sprite, (float)X - 20);
            SplashKit.SpriteSetY(this.Sprite, (float)Y - 40);
        }


        public override void Shoot() //shoot 2 green pea
        {
            base.Shoot();
            this.BulletPeas.Add(new GreenPea(this.X + 40, this.Y));
            this.BulletPeas.Add(new GreenPea(this.X, this.Y));
        }
    }


}
