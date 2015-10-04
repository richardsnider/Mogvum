using System.Collections.Generic;

namespace Assets.Scripts.Characters.BodyParts
{
    public class Anatomy
    {
        private Character Character { get; set; }

        //Strength affects MaxLife, MaxCarryWeight, and melee/ranged abilities.
        //It is determined by an energy usage to CarryWeight ratio.
        public int Strength { get; private set; }
        //Vitality affects LifeRegen, MaxEnergy, and EnergyRegen.
        //It is determined by energy usage.
        public int Vitality { get; private set; }

        public int CarryWeight { get; private set; }
        public int MaxCarryWeight { get; private set; }

        public ICollection<IBodyPart> BodyParts { get; private set; }


        public Anatomy(Character character, int strength = 0, int vitality = 0, int carryWeight = 0, int maxCarryWeight = 0, ICollection<IBodyPart> bodyParts = null)
        {
            Character = character;
            Strength = strength;
            Vitality = vitality;
            CarryWeight = carryWeight;
            MaxCarryWeight = maxCarryWeight;
            BodyParts = bodyParts ?? new List<IBodyPart>();
        }
    }
}
