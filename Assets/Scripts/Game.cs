using Assets.Scripts.Testing;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assets.Scripts
{
    [Serializable]
    public class Game
    {
        public Guid Id;
        private DateTime saveDate;
        public float GameVersion, PatchNumber;
        public ICollection<LogEvent> LogEvents;

        public string Name;
        private World world;

        public Game(Guid id = new Guid(), DateTime? saveDate = null, 
            float gameVersion = 0, short patchNumber = 0, ICollection<LogEvent> logEvents = null,
            string name = null, World world = null)
        {
            this.Id = id;
            this.saveDate = saveDate ?? DateTime.Now;
            this.GameVersion = gameVersion;
            this.PatchNumber = patchNumber;
            this.LogEvents = logEvents ?? new List<LogEvent>();

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
