using Assets.Scripts.Utilities;
using UnityEngine.Assertions;

namespace Assets.Scripts.Testing
{
    public class Tests
    {
        public void GamePersistence()
        {
            string gameName = "Test Case Game Name";
            Game game = new Game(name: gameName);

            Persistence.Save(game);

            var loadedGame = Persistence.Load(game.Id);

            Assert.AreEqual(loadedGame.Name, gameName);
        }
    }
}
