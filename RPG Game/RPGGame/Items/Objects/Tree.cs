namespace RPGGame.Items.Objects
{
    public class Tree : Item
    {
        public Tree(string id, int x, int y, int sizeX, int sizeY)
            : base(id, x, y, sizeX, sizeY)
        {
            this.id = "Tree";
        }
    }
}
