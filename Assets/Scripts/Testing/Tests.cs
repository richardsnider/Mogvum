using Assets.Scripts.Utilities;
using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.Scripts.Testing
{
    public class Tests
    {
        public void GamePersistence()
        {
            Debug.Log("Beginning GamePersistence test.");
            string gameName = "Test Case Game Name";
            Game game = new Game(name: gameName);

            Persistence.Save(game);

            var loadedGame = Persistence.Load(game.Id);

            if (loadedGame.Name == gameName)
                Debug.Log("GamePersistence test passed.");
            else Debug.LogError("GamePersistence test failed. Loaded game name is " + loadedGame.Name + ", but should be " + gameName);
        }
    }
}
