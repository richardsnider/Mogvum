using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assets.Scripts;

namespace Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void CreateGame()
        {
            //var game = new Game("Test Game");

            Assert.AreEqual(2, 2);
        }
    }
}
