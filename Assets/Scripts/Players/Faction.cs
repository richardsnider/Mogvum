using System;
using System.Collections.Generic;
using Assets.Scripts.Characters;

namespace Assets.Scripts.Players
{
    [Serializable]
    public class Faction
    {
        private World world;
        private string name;
        private ICollection<Character> characters;

        public Faction(World world, string name = null, ICollection<Character> characters = null)
        {
            this.name = name ?? "DefaultFactionName"; //Need to add a generator!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            this.characters = characters ?? new List<Character>();
        }

        public void AddCharacter(Character character)
        {
            if(!characters.Contains(character))
                characters.Add(character);
        }
    }
}
