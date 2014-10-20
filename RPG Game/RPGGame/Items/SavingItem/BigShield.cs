namespace RPGGame.Items
{
    public class BigShield : Item
    {
        /// <summary>
        /// Shield of metal increase the defense points.
        /// </summary>
        /// <param name="id">Item name</param>
        /// <param name="defensePoints">Points to be added to defense of character</param>
        public BigShield(string id, int x, int y, int sizeX, int sizeY, int defensePoints)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Id = "Big Shield";
            this.DefensePoints = 100;
        }

        public int DefensePoints { get; set; }
    }
}
