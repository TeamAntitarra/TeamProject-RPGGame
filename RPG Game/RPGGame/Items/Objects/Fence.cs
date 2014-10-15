namespace RPGGame.Items.Objects
{
    public class Fence : Item
    {
        public Fence(string id, int x, int y, int sizeX, int sizeY)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Id = "Fence";
        }
    }
}
