namespace RPGGame.Items.SavingItem
{
    public class MagicShield : Item
    {
        /// <summary>
        /// Magic shield to protect character for limited time.
        /// </summary>
        /// <param name="id">Item name</param>
        /// <param name="duration">Duration of shield in ms</param>
        public MagicShield(string id, int x, int y, int sizeX, int sizeY, int duration)
            : base(id, x, y, sizeX, sizeY)
        {
            this.Id = "Magic Shield";
            this.Duration = 1500;
        }

        public int Duration { get; set; }
    }
}
