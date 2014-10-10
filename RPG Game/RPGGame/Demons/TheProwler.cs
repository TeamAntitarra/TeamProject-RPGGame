namespace RPGGame.Demons
{
    using System.Collections.Generic;

    public class TheProwler : Demon
    {
        public TheProwler(string id, int x, int y, int sizeX, int sizeY,
                int healthPoints, int defensePoints, int movementSpeed)
                : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
            {
                this.id = "The Prowler";
                this.MaximumHealthPoints = 60;
                this.DefensePoints = 30;
                this.MovementSpeed = 30;
                this.Inventory = new List<Item>(2);
            }

        //public TheProwler(string id, int healthPoints, int defensePoints, double range)
        //    : base(id, healthPoints, defensePoints, range)
        //{
        //    this.id = "The Prowler";
        //    this.HealthPoints = 60;
        //    this.DefensePoints = 30;
        //    this.Range = 20;
        //    this.Inventory = new List<Item>(2);
        //}

        public override void AddToInventory(Item item)
        {
            if (this.Inventory.Count < 2)
            {
                this.Inventory.Add(item);
            }
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}
