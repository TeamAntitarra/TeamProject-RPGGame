﻿namespace RPGGame.Humans
{
    using System.Collections.Generic;

    public class Woman : Human
    {
        public Woman(string id, int x, int y, int sizeX, int sizeY,
            int healthPoints, int defensePoints, int movementSpeed)
            : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
        {
            this.Id = "Woman";
            this.MaximumHealthPoints = 40;
            this.DefensePoints = 0;
            this.MovementSpeed = 20;
            this.Inventory = new List<Item>(1);
        }

        //public Woman(string id, int healthPoints, int defensePoints, double range)
        //    : base(id, healthPoints, defensePoints, range)
        //{
        //    this.id = "Woman";
        //    this.HealthPoints = 40;
        //    this.DefensePoints = 0;
        //    this.Range = 0;
        //    this.Inventory = new List<Item>(1);
        //}

        public override void AddToInventory(Item item)
        {
            if (this.Inventory.Count == 0)
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
