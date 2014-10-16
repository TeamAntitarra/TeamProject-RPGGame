namespace RPGGame.Items.Weapons
{
    public class LaserGun : Weapon
    {
        public LaserGun(string id, int x, int y, int sizeX, int sizeY, double range, DamageForce force)
            : base(id, x, y, sizeX, sizeY, range)
        {
            this.Id = "Laser Gun";
            this.Range = 30;
            force = DamageForce.Large;
        }
    }
}
