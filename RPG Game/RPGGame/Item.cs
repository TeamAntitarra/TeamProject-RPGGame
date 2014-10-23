namespace RPGGame
{
    public abstract class Item : GameObject
    {
        protected Item(string id, int x, int y, int sizeX, int sizeY)
            : base(id, x, y, sizeX, sizeY)
        {

        }
    }
}
