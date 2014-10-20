namespace RPGGame.Items.Objects
{
    public class Building : Item
    {
        public Building(string id, int x, int y, int sizeX, int sizeY)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Id = "Building";
        }
    }
}
