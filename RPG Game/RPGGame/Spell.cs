using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using RPGGame.Humans;
using RPGGame.Interfaces;

namespace RPGGame
{
    public abstract class Spell : GameObject, ITimeoutable, IRenderable
    {
        private int currentTimeout;

        protected Spell(string id, int x, int y, int sizeX, int sizeY, Magician caster, int power, int range, int maxTimeout) : base(id, x, y, sizeX, sizeY)
        {
            this.Caster = caster;
            this.Power = power;
            this.Range = range;
            this.MaxTimeout = maxTimeout;
            this.CurrentTimeout = 0;
        }

        public Magician Caster { get; set; }
        public int Power { get; set; }
        public int Range { get; set; }
        public int MaxTimeout { get; set; }

        public int CurrentTimeout
        {
            get { return this.currentTimeout; }
            set
            {
                if (value >= this.MaxTimeout)
                {
                    this.HasTimedOut = true;
                }

                this.currentTimeout = value;
            }
        }

        public abstract int MillisecTimeout { get; set; }
        public abstract int CurrentTImeout { get; set; }
        public bool HasTimedOut { get; set; }
    }
}