namespace RPGGame.Items
{
    public class Weapon : Item
    {
        public Weapon(string id, int x, int y, int sizeX, int sizeY, double range, DamageForce force)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Range = range;
        }

        public double Range { get; set; }
    }
}
