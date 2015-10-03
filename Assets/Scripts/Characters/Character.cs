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
        private RegionCube cube;
        private string firstName, lastName;
        public CharacterStats Stats;
        public Skill Skill;
        public Anatomy Anatomy;

        public Character(RegionCube cube, CharacterStats stats = null, Skill skill = null, Anatomy anatomy = null)
        {
            this.cube = cube;
            this.Stats = stats ?? new CharacterStats(this);
            this.Skill = skill ?? new Skill();
            this.Anatomy = anatomy ?? new Anatomy();
        }

        public void TakeTurn() { }
        public void UseAbility(IAbility ability, ICollection<object> targets)
        {
        }
    }
}
