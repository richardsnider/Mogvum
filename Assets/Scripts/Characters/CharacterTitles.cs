using System;
using System.Collections.Generic;

namespace Assets.Scripts.Characters
{
    [Serializable]
    public class CharacterTitles
    {
        private Character Character { get; set; }
        public ICollection<string> FirstNames { get; private set; }
        public ICollection<string> LastNames { get; private set; }
        public ICollection<string> Prefixes { get; private set; }
        public ICollection<string> Suffixes { get; private set; }

        public CharacterTitles(Character character, ICollection<string> firstNames = null, ICollection<string> lastNames = null, ICollection<string> prefixes = null, ICollection<string> suffixes = null )
        {
            Character = character;
            FirstNames = firstNames ?? new List<string>();
            LastNames = lastNames ?? new List<string>();
            Prefixes = prefixes ?? new List<string>();
            Suffixes = suffixes ?? new List<string>();
        }
    }
}
