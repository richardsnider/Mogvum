using Assets.Scripts.Enumerables;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class World
    {
        private Game game;
        private ICollection<Faction> factions;
        private ICollection<Region> regions;

        public World(Game game, ICollection<Faction> factions = null, ICollection<Region> regions = null, int startingFactions = 1, int startingRegions = 1)
        {
            this.game = game;
            this.factions = factions ?? new List<Faction>();
            this.regions = regions ?? new List<Region>();

            if(this.factions.Count < 1)
            {
                AddFactions(startingFactions);
            }

            if(this.regions.Count < 1)
            {
                AddRegions(startingRegions);
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
            if (numFactions < 1) numFactions = 1;

            for(; numFactions > 0; numFactions--)
            {
                factions.Add(new Faction(this));
            }
        }

        public void AddRegions(int numRegions)
        {
            if (numRegions < 1) numRegions = 1;

            for(; numRegions > 0; numRegions--)
            {
                //What is the best way to calculate coordinates?
                regions.Add(new Region(this, 0, 0, "test", TerrainType.Fog));
            }
        }

        public void RemoveFaction(Faction faction)
        {
            if(factions.Contains(faction))
            {
                factions.Remove(faction);
            }
        }

        public void MoveCharacter(RegionCube src, RegionCube dst, Character character)
        {
            src.AddOccupant(dst.RemoveOccupant(character));
        }
    }
}
