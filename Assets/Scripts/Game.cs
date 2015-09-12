using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assets.Scripts
{
    [Serializable]
    public class Game
    {
        private string name;
        private World world;
        private DateTime lastSaveDate;

        public Game(string name, World world = null, DateTime? lastSaveDate = null)
        {
            this.name = name;
            this.world = world ?? new World(this);
            this.lastSaveDate = lastSaveDate ?? DateTime.Now;
        }

        public void Play()
        {
            world.Resume();
        }

    }
}
