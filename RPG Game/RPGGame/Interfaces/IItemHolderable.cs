namespace RPGGame.Interfaces
{
    using System.Collections.Generic;

    public interface IItemHolderable
    {
        List<Item> Inventory { get; set; }

        void AddToInventory(Item item);

        void RemoveFromInventory(Item item);
    }
}
