using Assets.Scripts.Enumerables;
using System.Collections.Generic;

namespace Assets.Scripts
{


    public class World
    {
        private Game game;
        private ICollection<Faction> factions;
        private ICollection<Region> regions;

        private int StartingFactions = 6;
        private int StartingRegions = 10;

        public World(Game game, ICollection<Faction> factions = null, ICollection<Region> regions = null)
        {
            this.game = game;
            if (regions != null) {
                this.factions = factions;
                this.regions = regions;
            }
            else
            {
                AddFactions(StartingFactions);
                AddRegions(StartingRegions);
            }
        }

        public void Resume()
        {
            foreach(var region in regions)
            {
                region.Day();
            }
        }

        public void Pause()
        {

        }

        public void AddFactions(int numFactions)
        {
            while(numFactions > 0)
            {
                factions.Add(new Faction(this));
                numFactions--;
            }
        }

        public void AddRegions(int numRegions)
        {
            while(numRegions > 0)
            {
                //What is the best way to calculate coordinates?
                regions.Add(new Region(this, 0, 0, TerrainType.Normal));
                numRegions--;
            }
        }

        public void RemoveFaction(Faction faction)
        {
            factions.Remove(faction);
        }

        public void MoveCharacter(Region src, Region dst, Character character)
        {
            src.RemoveOccupant(character);
            dst.AddOccupant(character);
        }
    }
}
