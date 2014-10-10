namespace RPGGame
{
    using RPGGame.Interfaces;
    using System.Collections.Generic;

    public abstract class Character : GameObject, ICharacter, IMovable
    {
        private int currentHealthPoints;

        protected Character(string id, int x, int y, int sizeX, int sizeY,
            int healthPoints, int defensePoints, int movementSpeed)
            : base(id, x, y, sizeX, sizeY)
        {
            this.MaximumHealthPoints = healthPoints;
            this.CurrentHealthPoints = this.MaximumHealthPoints;
            this.DefensePoints = defensePoints;
            this.MovementSpeed = movementSpeed;
            this.Inventory = new List<Item>();
        }

        public int CurrentHealthPoints
           {
            get
            {
                return this.currentHealthPoints;
            }
            set
            {
                if (value < 0)
                {
                    this.currentHealthPoints = 0;
                }
                else
                {
                    this.currentHealthPoints = value;
                }
            }
        }

        public int MaximumHealthPoints { get; set; }

        public int MovementSpeed { get; set; }

        public bool IsAlive
        {
            get
            {
                if (this.currentHealthPoints > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int DefensePoints { get; set; }
     
        public Direction Direction { get; set; }

        public List<Item> Inventory { get; set; }

        public abstract void AddToInventory(Item item);

        public abstract void RemoveFromInventory(Item item);
      
        public virtual void Move()
        {
            this.X += this.Direction.DirectionX * this.MovementSpeed;
            this.Y += this.Direction.DirectionY * this.MovementSpeed;
        }
    }
}
