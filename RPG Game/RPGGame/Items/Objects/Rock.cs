namespace RPGGame.Items.Objects
{
    public class Rock : Item
    {
        public Rock(string id, int x, int y, int sizeX, int sizeY)
            : base(id, x, y, sizeX, sizeY)
        {
            this.id = "Rock";
        }
    }
}
