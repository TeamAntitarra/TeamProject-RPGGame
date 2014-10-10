namespace RPGGame.Demons
{
    public class Zombie : Demon
    {
        public Zombie(string id, int x, int y, int sizeX, int sizeY,
            int healthPoints, int defensePoints, int movementSpeed)
            : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
        {
            this.id = "Zombie";
            this.MaximumHealthPoints = 30;
            this.DefensePoints = 10;
            this.MovementSpeed = 10;
        }
        //public Zombie(string id, int healthPoints, int defensePoints, double range)
        //    : base(id, healthPoints, defensePoints, range)
        //{
        //    this.id = "Zombie";
        //    this.HealthPoints = 30;
        //    this.DefensePoints = 10;
        //    this.Range = 10;
        //}
    }
}
