namespace RPGGame.Demons
{
    using RPGGame.Interfaces;

    public class Succubus : Demon, IFlyable
    {
        private const string Id = "Succubus";
        private const int HealthPoints = 100;
        private const int DefensePoints = 70;
        private const int MovementSpeed = 12;

        public Succubus(int x, int y, int sizeX, int sizeY)
            : base(Id, x, y, sizeX, sizeY, HealthPoints, DefensePoints, MovementSpeed)
            {
       
            }

        public void Fly()
        {
            throw new System.NotImplementedException();
        }
    }
}
