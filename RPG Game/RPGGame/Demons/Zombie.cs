namespace RPGGame.Demons
{
    public class Zombie : Demon
    {
        private const string Id = "Zombie";
        private const int HealthPoints = 30;
        private const int DefensePoints = 20;
        private const int MovementSpeed = 1;

        public Zombie(int x, int y, int sizeX, int sizeY)
            : base(Id, x, y, sizeX, sizeY, HealthPoints, DefensePoints, MovementSpeed)
            {
       
            }
    }
}
