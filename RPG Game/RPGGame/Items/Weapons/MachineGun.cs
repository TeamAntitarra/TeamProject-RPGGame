namespace RPGGame.Items.Weapons
{
    public class MachineGun : Weapon
    {
        public MachineGun(string id, int x, int y, int sizeX, int sizeY, double range, DamageForce force)
            : base(id, x, y, sizeX, sizeY, range)
        {
            this.Id = "Machine Gun";
            this.Range = 40;
            force = DamageForce.Middle;
        }
    }
}
