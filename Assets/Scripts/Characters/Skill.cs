using System;
using System.Linq;

namespace Assets.Scripts.Characters
{
    [Serializable]
    public class Skill
    {
        public int[] Alchemy; //Size = (Enum.GetNames(typeof(Alchemy)).Length)
        public int[] Arcana;
        public int[] Architecture;
        public int[] Carpentry;
        public int[] Craftsmanship;
        public int[] Escape;
        public int[] Kinesis;
        public int[] Language;
        public int[] Mechanics;
        public int[] Melee;
        public int[] Perception;
        public int[] Persuasion;
        public int[] Ranged;
        public int[] Smithing;
        public int[] Sorcery;
        public int[] Stealth;
        public int[] Swimming;
        public int[] Taming;

        public int GetAlchemyLevel()
        {
            return Alchemy.Sum();
        }

        //USAGE: character.Skill.GetAlchemyAbilityUsage(Alchemy.Food)
        public int GetAlchemyAbilityUsage(int ability)
        {
            return Alchemy[ability];
        }
    }
}
