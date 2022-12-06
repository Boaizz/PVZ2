namespace CustomProgram
{
    public class FactoryBucketheadZombie : ZombieFactory //concretecreator 
    {
        public Zombie GetZombie()
        {
            Zombie zombie = new BucketheadZombie();
            return zombie;
        }
    }
}
