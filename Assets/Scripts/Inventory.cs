using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Inventory
    {
        private bool bottomless; //RegionCube's have bottomless inventory
        private int width, length;
        private ICollection<Item> Items;

        public Inventory(int width, int length, bool bottomless = false, ICollection<Item> Items = null)
        {
            this.width = width;
            this.length = length;
            this.bottomless = bottomless;
            this.Items = Items ?? new List<Item>();
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
