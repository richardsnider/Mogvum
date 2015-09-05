using Assets.Scripts.Interfaces;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class CharacterStats
    {
        public Allegiance Allegiance;
        public CharacterType Type;

        public int Size;
        public int ActionPoints, MaxActionPoints;
        //Are Accuracy, DodgeRating, and BlockRating needed?

        CharacterStats(Allegiance allegiance, CharacterType Type, int Size)
        {

        }
    }
}
