using System;

namespace Assets.Scripts
{
    [Serializable]
    public class Game
    {
        public Guid Id { get; private set; }
        public DateTime SaveDate { get; private set; }
        public float GameVersion { get; set; }
        public float PatchNumber { get; set; }

        public string Name { get; private set; }
        private World World { get; set; }

        public Game(Guid id = new Guid(), DateTime? saveDate = null, 
            float gameVersion = 0, short patchNumber = 0,
            string name = null, World world = null)
        {
            Id = (id == Guid.Empty) ? Guid.NewGuid() : id;
            SaveDate = saveDate ?? DateTime.Now;
            GameVersion = gameVersion;
            PatchNumber = patchNumber;

            Name = name;
            World = world ?? new World(this);
        }

        public void Play()
        {
            World.Resume();
        }

        public void UpdateSaveDate()
        {
            SaveDate = DateTime.Now;
        }

    }
}
