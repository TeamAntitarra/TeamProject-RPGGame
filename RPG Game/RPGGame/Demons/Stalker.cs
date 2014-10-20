namespace RPGGame.Demons
{
    public class Stalker : Demon
    {
        private const string Id = "Stalker";
        private const int HealthPoints = 100;
        private const int DefensePoints = 50;
        private const int MovementSpeed = 14;

        public Stalker(int x, int y, int sizeX, int sizeY)
            : base(Id, x, y, sizeX, sizeY, HealthPoints, DefensePoints, MovementSpeed)
            {
       
            }
    }
}
