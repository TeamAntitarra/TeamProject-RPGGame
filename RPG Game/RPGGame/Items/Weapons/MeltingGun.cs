namespace RPGGame.Items.Weapons
{
    public class MeltingGun : Weapon
    {
        public MeltingGun(string id, int x, int y, int sizeX, int sizeY, double range, DamageForce force)
            : base(id, x, y, sizeX, sizeY, range)
        {
            this.Id = "Melting Gun";
            this.Range = 40;
            force = DamageForce.ExtraLarge;
        }
    }
}
