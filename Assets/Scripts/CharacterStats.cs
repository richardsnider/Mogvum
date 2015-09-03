namespace Assets.Scripts
{
    public class CharacterStats
    {
        public Allegiance Allegiance;

        //Need to add body part class and make that basis for life levels

        public int Size;

        public int Life, MaxLife, LifeRegen;
        public int Soul, MaxSoul, SoulRegen;
        public int Energy, MaxEnergy, EnergyRegen;
        public int ActionPoints, MaxActionPoints;
        public int CarryWeight, MaxCarryWeight;
        //Are Accuracy, DodgeRating, and BlockRating needed?

        //Strength affects MaxLife, MaxCarryWeight, and melee/ranged abilities.
        //It is determined by an energy usage to CarryWeight ratio.
        public int Strength;

        //Vitality affects LifeRegen, MaxEnergy, and EnergyRegen.
        //It is determined by energy usage.
        public int Vitality;
    }
}
