namespace RPGGame.Humans
{
    using System.Collections.Generic;
    using RPGGame.Interfaces;

    public class Woman : Human, IItemHolderable
    {
        private const string Id = "Woman";
        private const int HealthPoints = 100;
        private const int DefensePoints = 0;
        private const int MovementSpeed = 2;

        public Woman(int x, int y, int sizeX, int sizeY)
            : base(Id, x, y, sizeX, sizeY, HealthPoints, DefensePoints, MovementSpeed)
        {
             this.Inventory = new List<Item>(1);
        }

        public List<Item> Inventory { get; set; }

        public void AddToInventory(Item item)
        {
            if (this.Inventory.Count < 1)
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
