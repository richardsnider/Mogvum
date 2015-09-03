using System.Collections.Generic;

namespace Assets.Scripts
{
    public class Allegiance
    {
        private Dictionary<string, int> factionLoyalty;
        private int contentment;

        public int GetAllegiance(string factionName)
        {
            return factionLoyalty[factionName];
        }

        public int GetContentment()
        {
            return contentment;
        }

        public void IncrementAllegiance(string factionName, int value)
        {
            factionLoyalty[factionName] += value;
        }

        public void IncrementContentment(int value)
        {
            contentment += value;
        }

        public void DecrementAllegiance(string factionName, int value)
        {
            factionLoyalty[factionName] -= value;
        }

        public void DecrementContentment(int value)
        {
            contentment -= value;
        }
    }
}
