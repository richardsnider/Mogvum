using System.Collections.Generic;

namespace Assets.Scripts
{
    class Faction
    {
        public int Id;
        public string Name;
        ICollection<Character> Characters;
    }
}
