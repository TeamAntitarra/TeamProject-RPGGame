namespace RPGGame.Items
{
    public class PackHealth : Item
    {
        /// <summary>
        /// Pack health to increase the health points
        /// </summary>
        /// <param name="id">Item name</param>
        /// <param name="healthPoints">Add points to health of character</param>
        public PackHealth(string id, int healthPoints)
            : base(id)
        {
            this.id = "Pack Health";
            this.HealthPoints = 50;
        }

        public int HealthPoints { get; set; }
    }
}
