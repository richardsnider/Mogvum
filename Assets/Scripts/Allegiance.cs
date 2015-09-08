using System;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class Allegiance
    {
        private IDictionary<Guid, int> FactionLoyalty;
        private int contentment;

        public Allegiance()
        {
            FactionLoyalty = new Dictionary<Guid, int>();
        }

        public int GetAllegiance(Guid factionName)
        {
            return FactionLoyalty[factionName];
        }

        public int GetContentment()
        {
            return contentment;
        }

        public void IncrementAllegiance(Guid factionName, int value)
        {
            FactionLoyalty[factionName] += value;
        }

        public void IncrementContentment(int value)
        {
            contentment += value;
        }

        public void DecrementAllegiance(Guid factionName, int value)
        {
            FactionLoyalty[factionName] -= value;
        }

        public void DecrementContentment(int value)
        {
            contentment -= value;
        }
    }
}
