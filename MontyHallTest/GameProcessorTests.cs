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
    public class GameProcessorTests
    {
        [TestMethod()]
        public void ProcessTest()
        {
            Mock<IGenerator> generator = new Mock<IGenerator>();
            generator.Setup(g => g.GenerateRandomNumber(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
            //generator.Setup(m => m.GenerateRandomNumber(1, 4)).Returns(3);
            //generator.Setup(m => m.GenerateRandomNumber(0, 2)).Returns(1);
            GameProcessor gameProcessor = new GameProcessor(generator.Object);
            Strategy strategy = Strategy.Keep;
            Result result = gameProcessor.Process(strategy);
            Assert.IsFalse(result.IsPlayerSwitchedDoor);
            Assert.IsTrue(result.IsPlayerWins);
        }
    }
}