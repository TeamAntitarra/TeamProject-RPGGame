namespace RPGGame.Items
{
    public class Weapon : Item
    {
        public Weapon(string id, int x, int y, int sizeX, int sizeY, double range, DamageForce force)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Range = range;
            this.Force = force;
        }

        public double Range { get; set; }

        public DamageForce Force { get; set; }
    }
}
