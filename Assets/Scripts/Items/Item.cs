using System;

namespace Assets.Scripts.Items
{
    [Serializable]
    public class Item
    {
        protected Inventory ContainingInventory { get; set; } //Handle to containing ContainingInventory.
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int Size { get; private set; }
        public Condition Condition { get; set; }
        public bool Equippable { get; private set; }

        public Item(Inventory containingInventory, string name = null, int weight = 0, int size = 0, Condition condition = null, bool equippable = false)
        {
            ContainingInventory = containingInventory;
            Name = name;
            Weight = (weight < 0) ? 0 : weight;
            Size = (size < 0) ? 0 : size;
            Condition = condition ?? new Condition(this);
            Equippable = equippable;
        }
    }
}
