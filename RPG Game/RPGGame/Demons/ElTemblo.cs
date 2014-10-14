namespace RPGGame.Demons
{
    using System.Collections.Generic;
    using RPGGame.Interfaces;
    using RPGGame.Items;
    using RPGGame.Items.Weapons;

    public class ElTemblo : Demon, IFightable
    {
        public ElTemblo(string id, int x, int y, int sizeX, int sizeY,
            int healthPoints, int defensePoints, int movementSpeed, MeltingGun meltingGun)
            : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
        {
            this.id = "El Temblo";
            this.MaximumHealthPoints = 70;
            this.DefensePoints = 50;
            this.MovementSpeed = 50;
            this.Weapon = meltingGun;
            this.Inventory = new List<Item>(2);
        }

        //public ElTemblo(string id, int healthPoints, int defensePoints, double range)
        //    : base(id, healthPoints, defensePoints, range)
        //{
        //    this.id = "El Temblo";
        //    this.HealthPoints = 70;
        //    this.DefensePoints = 50;
        //    this.Range = 20;
        //    this.Inventory = new List<Item>(2);
        //}

        public Weapon Weapon { get; set; }

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
