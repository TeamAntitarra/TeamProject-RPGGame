namespace RPGGame.Items.Objects
{
    public class Truck : Item
    {
        public Truck(string id, int x, int y, int sizeX, int sizeY)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Id = "Truck";
        }
    }
}
