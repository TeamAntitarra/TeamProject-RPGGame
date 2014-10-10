namespace RPGGame.Humans
{
    using System.Collections.Generic;

    public class Agent : Human
    {
        public Agent(string id, int x, int y, int sizeX, int sizeY,
            int healthPoints, int defensePoints, int movementSpeed, Item laserGun)
            : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
        {
            this.id = "Agent";
            this.MaximumHealthPoints = 90;
            this.DefensePoints = 50;
            this.MovementSpeed = 50;
            this.LaserGun = laserGun;
            this.Inventory = new List<Item>(4);
        }

        //public Agent(string id, int healthPoints, int defensePoints, double range)
        //    : base(id, healthPoints, defensePoints, range)
        //{
        //    this.id = "Agent";
        //    this.HealthPoints = 90;
        //    this.DefensePoints = 50;
        //    this.Range = 5;
        //    this.Inventory = new List<Item>(4); 
        //}
        public Item LaserGun { get; set; }

        public override void AddToInventory(Item item)
        {
            if (this.Inventory.Count < 4)
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
