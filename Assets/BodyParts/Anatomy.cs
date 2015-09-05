using Assets.Scripts.Interfaces;
using System.Collections.Generic;

namespace Assets
{
    class Anatomy
    {
        //Strength affects MaxLife, MaxCarryWeight, and melee/ranged abilities.
        //It is determined by an energy usage to CarryWeight ratio.
        public int Strength;
        //Vitality affects LifeRegen, MaxEnergy, and EnergyRegen.
        //It is determined by energy usage.
        public int Vitality;

        public ICollection<IBodyPart> BodyParts;

        public int CarryWeight, MaxCarryWeight;

    }
}
