namespace RPGGame.Items
{
    public class Armor : Item
    {
        /// <summary>
        /// Kevlar armor increase the defense points
        /// </summary>
        /// <param name="id">Item name</param>
        /// <param name="defensePoints">Add points to defense of character</param>
        public Armor(string id, int defensePoints)
            : base(id)
        {
            this.id = "Armor";
            this.DefensePoints = 50;
        }

        public int DefensePoints { get; set; }
    }
}
