﻿using Assets.Scripts.Effects;
using Assets.Scripts.Interfaces;
using System.Collections.Generic;

namespace Assets.Scripts.BodyParts
{
    class BodyPart : IBodyPart
    {
        private ICollection<Item> EquippedItems;
        private bool Grip;
        private int Life, MaxLife, LifeRegen;
        private int Energy, MaxEnergy, EnergyRegen;

        ICollection<Effect> Effects; //Is this redundant? I feel like you should be able to add an effect to a body part specifically.
        private bool Spectral; //Life can be zero.
        private int Soul, MaxSoul, SoulRegen; //Because what if you have an arm made of fire or something crazy like that. Or what if you have a bionic arm?

        public void EquipItem(Item item)
        {
            EquippedItems.Add(item);
        }

        public void UnEquipItem(Item item)
        {
            EquippedItems.Remove(item);
        }
    }
}
