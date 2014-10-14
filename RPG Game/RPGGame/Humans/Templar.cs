﻿namespace RPGGame.Humans
{
    using System.Collections.Generic;
    using RPGGame.Interfaces;
    using RPGGame.Items;
    using RPGGame.Items.Weapons;

    public class Templar : Human
    {
        public Templar(string id, int x, int y, int sizeX, int sizeY,
            int healthPoints, int defensePoints, int movementSpeed, TemplarSword templarSword)
            : base(id, x, y, sizeX, sizeY, healthPoints, defensePoints, movementSpeed)
        {
            this.id = "Templar";
            this.MaximumHealthPoints = 100;
            this.DefensePoints = 100;
            this.MovementSpeed = 100;
            this.Weapon = templarSword;
            this.Inventory = new List<Item>(5);
        }

        //public Templar(string id, int healthPoints, int defensePoints, double range, Item templarSword)
        //    : base(id, healthPoints, defensePoints, range)
        //{
        //    this.id = "Knight Templar";
        //    this.HealthPoints = 100;
        //    this.DefensePoints = 100;
        //    this.Range = 10;
        //    this.TemplarSword = templarSword;
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
