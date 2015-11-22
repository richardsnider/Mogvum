using System;
using Assets.Scripts.Characters.BodyParts;
using Assets.Scripts.Regions;

namespace Assets.Scripts.Characters
{
    [Serializable]
    public class Character
    {
        public RegionCube Cube { get; private set; }
        public CharacterTitles Titles { get; private set; }
        public Allegiance Allegiance { get; private set; }
        public CharacterType Type { get; private set; }
        public Anatomy Anatomy { get; private set; }
        public Skill Skill { get; private set; }
        public ActionPoints ActionPoints { get; private set; }

        public Character(RegionCube cube, CharacterTitles titles = null, Allegiance allegiance = null, CharacterType type = null,
           Anatomy anatomy = null, Skill skill = null, ActionPoints actionPoints = null)
        {
            Cube = cube;
            Titles = titles ?? new CharacterTitles();
            Allegiance = allegiance ?? new Allegiance(this);
            Type = type ?? new CharacterType(this);
            Anatomy = anatomy ?? new Anatomy(this);
            Skill = skill ?? new Skill();
            ActionPoints = actionPoints ?? new ActionPoints(this);
        }

        public void Destroy()
        {
            Cube.RemoveOccupant(this);
        }
    }
}
