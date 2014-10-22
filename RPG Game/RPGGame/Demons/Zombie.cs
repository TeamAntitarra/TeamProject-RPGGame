namespace RPGGame.Demons
{
    using System;

    public class Zombie : Demon
    {
        private const string Id = "Zombie";
        private const int HealthPoints = 30;
        private const int DefensePoints = 20;
        private const int MovementSpeed = 1;

        protected static Random random = new Random();

        public Zombie(int x, int y, int sizeX, int sizeY)
            : base(Id, x, y, sizeX, sizeY, HealthPoints, DefensePoints, MovementSpeed)
        {
       
        }

        public override void Move()
        {
            int dirX = random.Next(-1, 2);
            int dirY = random.Next(-1, 2);
            this.Direction = new Direction(dirX, dirY);
            base.Move();
        }
    }
}
