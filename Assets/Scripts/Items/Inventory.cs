using System;
using System.Collections.Generic;

namespace Assets.Scripts.Items
{
    [Serializable]
    public class Inventory
    {
        public int Width { get; private set; }
        public int Length { get; private set; }
        public bool Bottomless { get; private set; } //A region cube has infinite inventory.
        public ICollection<Item> Items { get; private set; }

        public Inventory(int width, int length, bool bottomless = false, ICollection<Item> items = null)
        {
            Width = width;
            Length = length;
            Bottomless = bottomless;
            Items = items ?? new List<Item>();
        }

        public bool AddItem(Item item, int x, int y)
        {
            Items.Add(item);
            return true;
        }

        public Item RemoveItem(Item item)
        {
            Items.Remove(item);
            return item;
        }
    }
}
