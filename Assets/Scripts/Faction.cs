using System;
using System.Collections.Generic;

namespace Assets.Scripts
{
    class Faction
    {
        public Guid Id;
        public string Name;
        ICollection<Character> Characters;

        public Faction()
        {
            Id = new Guid();
            Name = "DefaultFactionName"; //Need to add a generator!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
         
            Characters = new List<Character>();
        }

        public void AddCharacter(Character character)
        {
            Characters.Add(character);
        }
    }
}
