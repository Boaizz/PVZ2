using SplashKitSDK;

namespace CustomProgram
{
    public class DoorZombie : Zombie
    {
     
        public DoorZombie() : base("Door Zombie", "shieldzombie.png")
        {
            int row = SplashKit.Rnd(0, 5);
            if (row == 4)
            {
                Y = 120 + 95 * row;
            }
            else if (row == 3)
            {
                Y = 110 + 95 * row;
            }
            else if (row == 0)
            {
                Y = 80;
            }
            else if (row == 1)
            {
                Y = 90 + 95 * row;
            }
            else
            {
                Y = 100 + 95 * row;
            }
            X = SplashKit.ScreenWidth() + 10;
            Health = 500;
            Vector2D _vel = new Vector2D();
            _vel.X = -0.5;
            _vel.Y = 0;
            Vel = _vel;
            Damage = 99;
            Row = row;
            SplashKit.SpriteSetX(this.Sprite, (float)X);
            SplashKit.SpriteSetY(this.Sprite, (float)Y);
            SplashKit.SpriteSetVelocity(this.Sprite, Vel);
            SplashKit.SpriteAddLayer(this.Sprite, new Bitmap("Normal Zombie", "normalzombie.png"), "Normal Zombie");
            SplashKit.SpriteAddLayer(Sprite, new Bitmap("Normal Zombie Attack", "NormalZombieAttack.png"), "Attack");
        }

        public override void ChangeLayer()
        {
            if (this.Health > 100)
            {
                SplashKit.SpriteShowLayer(this.Sprite, 0);
                SplashKit.SpriteHideLayer(this.Sprite, 1);
                SplashKit.SpriteHideLayer(this.Sprite, 2);
            }
            else if (this.Health <= 100 && this.IsEating)
            {
                SplashKit.SpriteHideLayer(this.Sprite, 0);
                SplashKit.SpriteHideLayer(this.Sprite, 1);
                SplashKit.SpriteShowLayer(this.Sprite, 2);
            }
            else if (this.Health <= 100 && !this.IsEating)
            {
                SplashKit.SpriteHideLayer(this.Sprite, 2);
                SplashKit.SpriteHideLayer(this.Sprite, 0);
                SplashKit.SpriteShowLayer(this.Sprite, 1);
            }

        }


    }
}
