using System;
using System.Collections.Generic;

namespace Assets.Scripts
{
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
            characters.Add(character);
        }
    }
}
