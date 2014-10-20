namespace RPGGame.Demons
{
    using RPGGame.Interfaces;

    public class Succubus : Demon, IFlyable
    {

        public Succubus(string id, int x, int y, int sizeX, int sizeY,
                int healthPoints, int defensePoints, int movementSpeed)
                : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
            {
                this.Id = "Succubus";
                this.MaximumHealthPoints = 100;
                this.DefensePoints = 70;
                this.MovementSpeed = 70;
            }

        //public Succubus(string id, int healthPoints, int defensePoints, double range)
        //    : base(id, healthPoints, defensePoints, range)
        //{
        //    this.id = "Succubus";
        //    this.HealthPoints = 100;
        //    this.DefensePoints = 70;
        //    this.Range = 30;
        //}
    }
}
