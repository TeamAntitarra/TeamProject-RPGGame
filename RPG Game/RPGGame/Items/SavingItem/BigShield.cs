namespace RPGGame.Items
{
    public class BigShield : Item
    {
        /// <summary>
        /// Shield of metal increase the defense points
        /// </summary>
        /// <param name="id">Item name</param>
        /// <param name="defensePoints">Add points to defense of character</param>
        public BigShield(string id, int defensePoints)
            : base(id)
        {
            this.id = "Big Shield";
            this.DefensePoints = 100;
        }

        public int DefensePoints { get; set; }
    }
}
