namespace RPGGame.Demons
{
    using System.Collections.Generic;
    using RPGGame.Interfaces;
    using RPGGame.Items;
    using RPGGame.Items.Weapons;

    public class LordTruikwor : Demon, IFightable
    {
        public LordTruikwor(string id, int x, int y, int sizeX, int sizeY,
                int healthPoints, int defensePoints, int movementSpeed, MeltingGun meltingGun)
                : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
            {
                this.id = "Lord Truikwor";
                this.MaximumHealthPoints = 100;
                this.DefensePoints = 100;
                this.MovementSpeed = 90;
                this.Weapon = meltingGun;
                this.Inventory = new List<Item>(2);
            }

            //public LordTruikwor(string id, int healthPoints, int defensePoints, double range)
            //    : base(id, healthPoints, defensePoints, range)
            //{
            //    this.id = "Lord Truikwor";
            //    this.HealthPoints = 100;
            //    this.DefensePoints = 100;
            //    this.Range = 30;
            //    this.Inventory = new List<Item>(5);
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