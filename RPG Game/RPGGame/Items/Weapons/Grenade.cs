namespace RPGGame.Items.Weapons
{
    public class Grenade : Weapon
    {
        public Grenade(string id, int x, int y, int sizeX, int sizeY, double range, DamageForce force)
            : base(id, x, y, sizeX, sizeY, range, force)
        {
            this.id = "Grenade";
            this.Range = 20;
            force = DamageForce.Middle;
        }
    }
}
