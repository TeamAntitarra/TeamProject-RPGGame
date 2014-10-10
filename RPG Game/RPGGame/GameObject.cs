namespace RPGGame
{
    using RPGGame.Interfaces;

    public abstract class GameObject : IGameObject
    {
        protected GameObject(string id, int x, int y, int sizeX, int sizeY)
        {
            this.id = id;
            this.X = x;
            this.Y = y;
            this.SizeX = sizeX;
            this.SizeY = sizeY;
        }

        public string id { get; set; }

        public int X { get; set; }
        
        public int Y { get; set; }
   
        public int SizeX { get; set; }

        public int SizeY { get; set; }
  
    }
}
