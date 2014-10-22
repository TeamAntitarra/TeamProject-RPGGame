namespace RPGGame.Humans
{
    using System.Collections.Generic;
    using RPGGame.Interfaces;
    using RPGGame.Items;
    using RPGGame.Items.Weapons;

    public class Templar : Human, IItemHolderable
    {
        private const string Id = "Templar";
        private const int HealthPoints = 100;
        private const int DefensePoints = 100;
        private const int MovementSpeed = 20;

        public Templar(int x, int y, int sizeX, int sizeY)
            : base(Id, x, y, sizeX, sizeY, HealthPoints, DefensePoints, MovementSpeed)
        {
            
            this.Inventory = new List<Item>(5);
        }

        public Weapon Weapon { get; set; }

        public List<Item> Inventory { get; set; }

        public void AddToInventory(Item item)
        {
            if (this.Inventory.Count < 5)
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
