namespace RPGGame.Humans
{
    using System.Collections.Generic;
    using RPGGame.Interfaces;
    using RPGGame.Items;
    using RPGGame.Items.Weapons;

    public class Magician : Human, IFightable
    {
        public Magician(string id, int x, int y, int sizeX, int sizeY,
            int healthPoints, int defensePoints, int movementSpeed, Magic magic)
            : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
        {
            this.Id = "Magician";
            this.MaximumHealthPoints = 100;
            this.DefensePoints = 90;
            this.MovementSpeed = 90;
            this.Weapon = magic;
            this.Inventory = new List<Item>(5);
        }

        //public Magician(string id, int healthPoints, int defensePoints, double range)
        //    : base(id, healthPoints, defensePoints, range)
        //{
        //    this.id = "Magician";
        //    this.HealthPoints = 100;
        //    this.DefensePoints = 90;
        //    this.Range = 30;
        //    this.Inventory = new List<Item>(3);
        //}
        public Weapon Weapon { get; set; }

        public override void AddToInventory(Item item)
        {
            if (this.Inventory.Count < 5)
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
