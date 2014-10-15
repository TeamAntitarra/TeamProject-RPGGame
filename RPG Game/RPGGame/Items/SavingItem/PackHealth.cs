namespace RPGGame.Items
{
    public class PackHealth : Item
    {
        /// <summary>
        /// Pack health to increase the health points.
        /// </summary>
        /// <param name="id">Item name</param>
        /// <param name="healthPoints">Points to be added to the health of character</param>
        public PackHealth(string id, int x, int y, int sizeX, int sizeY, int healthPoints)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Id = "Pack Health";
            this.HealthPoints = 50;
        }

        public int HealthPoints { get; set; }
    }
}
