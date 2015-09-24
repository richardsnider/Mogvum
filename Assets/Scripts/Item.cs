﻿using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;

namespace Assets.Scripts
{
    [Serializable]
    public class Item
    {
        Inventory inventory; //Handle to containing inventory.
        private string name = "DefaultItemName";
        private bool grippable;
        private int Weight;
        private int Quantity;
        private int Value;

        public Item(ICollection<IEffect> effects = null, Inventory inventory = null)
        {
        }

        public string GetName()
        {
            return name;
        }
    }
}
