using Assets.Scripts.Testing;
using System;
using System.Collections.Generic;

namespace Assets.Scripts
{
    [Serializable]
    public class Game
    {
        public Guid Id;
        private DateTime saveDate;
        public float GameVersion, PatchNumber;

        public string Name;
        private World world;

        public Game(Guid id = new Guid(), DateTime? saveDate = null, 
            float gameVersion = 0, short patchNumber = 0,
            string name = null, World world = null)
        {
            if(id == Guid.Empty)
                this.Id = Guid.NewGuid();
            else this.Id = id;

            this.saveDate = saveDate ?? DateTime.Now;
            this.GameVersion = gameVersion;
            this.PatchNumber = patchNumber;

            this.Name = name;
            this.world = world ?? new World(this);
        }

        public void Play()
        {
            world.Resume();
        }

        public void UpdateSaveDate()
        {
            saveDate = DateTime.Now;
        }

    }
}
