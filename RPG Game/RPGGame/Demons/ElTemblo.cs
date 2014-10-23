namespace RPGGame.Demons
{
    using System.Collections.Generic;
    using RPGGame.Interfaces;
    using RPGGame.Items;
    using RPGGame.Items.Weapons;
    using System;

    public class ElTemblo : Demon, IFightable, IItemHolderable
    {
        private const string Id = "El Temblo";
        private const int HealthPoints = 100;
        private const int DefensePoints = 50;
        private const int MovementSpeed = 5;

        protected static Random random = new Random();

        public ElTemblo(int x, int y, int sizeX, int sizeY)
            : base(Id, x, y, sizeX, sizeY, HealthPoints, DefensePoints, MovementSpeed)
        {
             this.Inventory = new List<Item>(2);
        }

        public Weapon Weapon { get; set; }

        public List<Item> Inventory { get; set; }

        public void AddToInventory(Item item)
        {
            if (this.Inventory.Count < 2)
            {
                this.Inventory.Add(item);
            }
        }

        public void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }

        public override void Move()
        {
            int dirX = random.Next(-1, 1);
            int dirY = random.Next(-1, 1);
            this.Direction = new Direction(dirX, dirY);
            base.Move();
        }
    }
}
