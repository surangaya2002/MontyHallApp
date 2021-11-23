using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHallApp;
using MontyHallApp.Interfaces;
using MontyHallApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp.Tests
{
    [TestClass()]
    public class GameTests
    {
        Game game;

        [TestInitialize]
        public void TestSetUp()
        {
            Mock<IGameProcessor> mockGameProcessor = new Mock<IGameProcessor>();
            Result result = new Result();
            result.IsPlayerSwitchedDoor = true;
            result.IsPlayerWins = true;
            mockGameProcessor.Setup(g => g.Process(It.IsAny<Strategy>())).Returns(result);
            game = new Game(Strategy.Keep, 2, mockGameProcessor.Object);
        }

        [TestMethod()]
        public void PlayTest()
        {
            Summary summary = game.Play();
            Assert.AreEqual(2, summary.NumberOfSimulations);
            Assert.AreEqual(2, summary.TotalWinningCount);
            Assert.AreEqual("100,0 %", summary.WinningPercentage);
            Assert.AreEqual(2, summary.SwitchedDoorCount);
        }

        [TestMethod()]
        public void StopTest()
        {
            bool result = game.Stop("exit");
            Assert.IsFalse(result);
        }
    }
}