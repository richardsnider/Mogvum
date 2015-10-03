using System.Collections.Generic;

namespace Assets.Scripts.BodyParts
{
    public class Anatomy
    {
        //Strength affects MaxLife, MaxCarryWeight, and melee/ranged abilities.
        //It is determined by an energy usage to CarryWeight ratio.
        private int Strength;
        //Vitality affects LifeRegen, MaxEnergy, and EnergyRegen.
        //It is determined by energy usage.
        private int Vitality;

        private ICollection<IBodyPart> BodyParts;

        private int CarryWeight, MaxCarryWeight;
    }
}
