namespace RPGGame.Items.Weapons
{
    public class TemplarSword : Weapon
    {
        public TemplarSword(string id, int x, int y, int sizeX, int sizeY, double range, DamageForce force)
            : base(id, x, y, sizeX, sizeY, range)
        {
            this.Id = "Templar Sword";
            this.Range = 5;
            force = DamageForce.Large;
        }
    }
}
