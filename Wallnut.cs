using SplashKitSDK;

namespace CustomProgram
{
    public class Wallnut : Plant
    {
        public Wallnut(double x, double y) :base("Wallnut", "Wallnut.png")
        {
            X = x;
            Y = y;
            Health = 300;
            SplashKit.SpriteSetX(this.Sprite, (float)X - 20);
            SplashKit.SpriteSetY(this.Sprite, (float)Y - 50);
            this.Sprite.AddLayer(new Bitmap("Wallnut Cracked 1", "Wallnut_cracked1.png"), "Cracked 1");
            this.Sprite.AddLayer(new Bitmap("Wallnut Cracked 2", "Wallnut_cracked2.png"), "Cracked 2");
        }

        public void ChangeLayer()
        {
            if (this.Health > 100 && this.Health <= 200)
            {
                SplashKit.SpriteHideLayer(this.Sprite, 0);
                SplashKit.SpriteShowLayer(this.Sprite, 1);
            } else if (this.Health <= 100) {
                SplashKit.SpriteHideLayer(this.Sprite, 1);
                SplashKit.SpriteShowLayer(this.Sprite, 2);
            }
        }

        public override void BeAttacked(Zombie zombie)
        {
            this.Health -= zombie.Damage;
        }
    }
}
