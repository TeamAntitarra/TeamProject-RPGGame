namespace RPGGame.Humans
{
    using System.Collections.Generic;
    using RPGGame.Interfaces;
    using RPGGame.Items;
    using RPGGame.Items.Weapons;

    public class Agent : Human, IFightable, IItemHolderable
    {
        private const string Id = "Agent";
        private const int HealthPoints = 100;
        private const int DefensePoints = 50;
        private const int MovementSpeed = 8;

        public Agent(int x, int y, int sizeX, int sizeY)
            : base(Id, x, y, sizeX, sizeY, HealthPoints, DefensePoints, MovementSpeed)
        {
             this.Inventory = new List<Item>(4);
        }

        public Weapon Weapon { get; set; } 

        public List<Item> Inventory { get; set; }

        public void AddToInventory(Item item)
        {
            if (this.Inventory.Count < 4)
            {
                this.Inventory.Add(item);
            }
        }

        public void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}
