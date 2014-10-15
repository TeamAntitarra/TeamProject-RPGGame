namespace RPGGame
{
    using RPGGame.Interfaces;

    public abstract class GameObject : IGameObject, IRenderable
    {
        protected GameObject(string id, int x, int y, int sizeX, int sizeY)
        {
            this.Id = id;
            this.X = x;
            this.Y = y;
            this.SizeX = sizeX;
            this.SizeY = sizeY;
        }

        public string Id { get; set; }

        public int X { get; set; }
        
        public int Y { get; set; }
   
        public int SizeX { get; set; }

        public int SizeY { get; set; }
  
    }
}
