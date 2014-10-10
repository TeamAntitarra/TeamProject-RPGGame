namespace RPGGame.Items.Weapons
{
    public class GrenadeLauncher : Weapon
    {
        public GrenadeLauncher(string id, int x, int y, int sizeX, int sizeY, double range, DamageForce force)
            : base(id, x, y, sizeX, sizeY, range, force)
        {
            this.id = "Grenade Launcher";
            this.Range = 50;
            force = DamageForce.Large;
        }
    }
}
