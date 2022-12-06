namespace CustomProgram
{
    public class FactoryConeheadZombie : ZombieFactory //concretecreator 
    {
        public Zombie GetZombie()
        {
            Zombie zombie = new ConeheadZombie();
            return zombie;
        }
    }
}
