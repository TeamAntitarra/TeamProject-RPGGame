namespace RPGGame.Items
{
    public class Armor : Item
    {
        /// <summary>
        /// Kevlar armor increase the defense points.
        /// </summary>
        /// <param name="id">Item name</param>
        /// <param name="defensePoints">Points to be added to defense of character</param>
        public Armor(string id, int x, int y, int sizeX, int sizeY, int defensePoints)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Id = "Armor";
            this.DefensePoints = 50;
        }

        public int DefensePoints { get; set; }
    }
}
