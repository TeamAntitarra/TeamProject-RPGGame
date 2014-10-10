namespace RPGGame
{
    public struct Direction
    {
        public Direction(int x, int y)
            : this()
        {
            this.DirectionX = x;
            this.DirectionY = y;
        }

        public int DirectionX { get; set; }

        public int DirectionY { get; set; }
    }
}
