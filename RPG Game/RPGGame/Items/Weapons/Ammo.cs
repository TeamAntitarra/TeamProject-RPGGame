namespace RPGGame.Items.Weapons
{
    // This means that increase ammunition of current weapon
    public class Ammo : Item
    {
        public Ammo(string id, int x, int y, int sizeX, int sizeY)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Id = "Ammo";
        }
    }
}
