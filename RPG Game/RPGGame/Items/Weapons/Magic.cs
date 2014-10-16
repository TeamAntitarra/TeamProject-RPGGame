namespace RPGGame.Items.Weapons
{
    public class Magic : Weapon
    {
        public Magic(string id, int x, int y, int sizeX, int sizeY, double range, DamageForce force)
            : base(id, x, y, sizeX, sizeY, range)
        {
            this.Id = "Magic";
            this.Range = 40;
            force = DamageForce.ExtraLarge;
        }
    }
}
