using System.Collections.Generic;

namespace Assets.Scripts
{
    public class Inventory
    {
        private int Capacity;
        private ICollection<Item> Items;

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }
    }
}
