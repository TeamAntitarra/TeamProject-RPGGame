namespace RPGGame.Items.Objects
{
    public class Rock : Item
    {
        private const string Id = "Rock";

        public Rock(int x, int y, int sizeX, int sizeY)
            : base(Id, x, y, sizeX, sizeY)
        {
 
        }
    }
}
