using SplashKitSDK;

namespace CustomProgram
{
    public class NormalZombie : Zombie
    {
        public NormalZombie() : base("Normal Zombie", "normalzombie.png")
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
            Health = 100;
            Vector2D _vel = new Vector2D();
            _vel.X = -0.5;
            _vel.Y = 0;
            Vel = _vel;
            Damage = 20;
            Row = row;
            SplashKit.SpriteSetX(this.Sprite, (float)X);
            SplashKit.SpriteSetY(this.Sprite, (float)Y);
            SplashKit.SpriteSetVelocity(this.Sprite, Vel);
            SplashKit.SpriteAddLayer(Sprite, new Bitmap("Normal Zombie Attack", "NormalZombieAttack.png"), "Attack");
        }

        public override void ChangeLayer()
        {
            if (this.IsEating)
            {
                SplashKit.SpriteHideLayer(this.Sprite, 0);
                SplashKit.SpriteShowLayer(this.Sprite, 1);
            } else
            {
                SplashKit.SpriteHideLayer(this.Sprite, 1);
                SplashKit.SpriteShowLayer(this.Sprite, 0);
            }
        }
    }
}
