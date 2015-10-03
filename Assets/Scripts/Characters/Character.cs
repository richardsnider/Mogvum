using System;
using System.Collections.Generic;
using Assets.Scripts.BodyParts;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Regions;

namespace Assets.Scripts.Characters
{
    [Serializable]
    public class Character
    {
        private RegionCube Cube { get; set; }
        private CharacterTitles Titles { get; set; }
        public Allegiance Allegiance { get; private set; }
        public CharacterType Type { get; private set; }
        public Anatomy Anatomy { get; private set; }
        public Skill Skill { get; private set; }
        private int ActionPoints { get; set; }
        private int MaxActionPoints { get; set; }

        public Character(RegionCube cube, CharacterTitles titles = null, Allegiance allegiance = null, CharacterType type = null,
           Anatomy anatomy = null, Skill skill = null)
        {
            Cube = cube;
            Titles = titles ?? new CharacterTitles(this);
            Allegiance = allegiance ?? new Allegiance(this);
            Type = type ?? new CharacterType(this);
            Anatomy = anatomy ?? new Anatomy();
            Skill = skill ?? new Skill();
            MaxActionPoints = 10;
            ActionPoints = 10;
        }

        public void TakeTurn()
        {
            
        }

        public void UseAbility(IAbility ability, ICollection<object> targets)
        {

        }
    }
}
