using System;
using Assets.Scripts.Enumerables;

namespace Assets.Scripts.Characters
{
    [Serializable]
    public class CharacterStats
    {
        private Character character;
        public CharacterTitles Titles;
        public Allegiance Allegiance;
        public CharacterType Type;
        public CharacterSize Size;
        private int actionPoints, maxActionPoints;
        //Are Accuracy, DodgeRating, and BlockRating needed?

        public CharacterStats(Character character, CharacterTitles titles = null, Allegiance allegiance = null, 
            CharacterType type = null, CharacterSize size = CharacterSize.Medium, int actionPoints = 0, int maxActionPoints = 10)
        {
            this.character = character;
            this.Titles = titles ?? new CharacterTitles();
            this.Allegiance = allegiance ?? new Allegiance();
            this.Type = type ?? new CharacterType();
            this.Size = size;
            this.actionPoints = actionPoints;
            this.maxActionPoints = maxActionPoints;
        }
    }
}
