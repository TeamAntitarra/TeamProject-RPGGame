namespace RPGGame.Items.Objects
{
    public class HellGate : Item
    {
        public HellGate(string id, int x, int y, int sizeX, int sizeY)
            : base(id, x, y, sizeX, sizeY)
        {
            this.id = "HellGate";
        }
    }
}