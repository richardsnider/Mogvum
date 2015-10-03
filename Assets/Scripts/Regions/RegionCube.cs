using System;
using System.Collections.Generic;
using Assets.Scripts.Characters;
using Assets.Scripts.Effects;
using Assets.Scripts.Items;

namespace Assets.Scripts.Regions
{
    [Serializable]
    public class RegionCube
    {
        private Region Region { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        public Matter Matter { get; private set; }
        public ICollection<IEffect> Effects { get; private set; }
        public ICollection<Character> Occupants { get; private set; }
        public Inventory Inventory { get; private set; }
        public int Cover { get; private set; }
        public int Lighting { get; private set; }

        public RegionCube(Region region, int x, int y, int z, Matter matter = Matter.Vacuum, ICollection<IEffect> effects = null,
            ICollection<Character> occupants = null, Inventory inventory = null, int cover = 0, int lighting = 100)
        {
            Region = region;
            X = x;
            Y = y;
            Z = z;
            Matter = matter;
            Effects = effects ?? new List<IEffect>();
            Occupants = occupants ?? new List<Character>();
            Inventory = inventory ?? new Inventory(0, 0, true);
            Cover = cover;
            Lighting = lighting;
        }

        public bool AddEffect(IEffect effect)
        {
            if (!Effects.Contains(effect))
            {
                Effects.Add(effect);
                return true;
            }

            return false;
        }

        public IEffect RemoveEffect(IEffect effect)
        {
            if (Effects.Contains(effect))
            {
                Effects.Remove(effect);
                return effect;
            }

            return null;
        }

        public bool AddOccupant(Character character)
        {
            if ((character.Type.Size <= CharacterSize.Tiny || Occupants.Count == 0)
                && !Occupants.Contains(character))
            {
                Occupants.Add(character);
                return true;
            }

            return false;
        }

        public Character RemoveOccupant(Character character)
        {
            if (Occupants.Contains(character))
            {
                Occupants.Remove(character);
                return character;
            }

            return null;
        }
    }
}
