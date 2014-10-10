namespace RPGGame.Demons
{
    public class Stalker : Demon
    {
        public Stalker(string id, int x, int y, int sizeX, int sizeY,
                int healthPoints, int defensePoints, int movementSpeed)
                : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
            {
                this.id = "Stalker";
                this.MaximumHealthPoints = 50;
                this.DefensePoints = 50;
                this.MovementSpeed = 50;
            }

        //public Stalker(string id, int healthPoints, int defensePoints, double range)
        //    : base(id, healthPoints, defensePoints, range)
        //{
        //    this.id = "Stalker";
        //    this.HealthPoints = 50;
        //    this.DefensePoints = 50;
        //    this.Range = 10;
        //}
    }
}
