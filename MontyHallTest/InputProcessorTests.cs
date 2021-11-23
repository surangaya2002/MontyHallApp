using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHallApp;
using System;
using System.Collections.Generic;
using System.Text;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp.Tests
{
    [TestClass()]
    public class InputProcessorTests
    {
        [TestMethod()]
        public void GetStrategySwitchTest()
        {
            InputProcessor inputProcessor = new InputProcessor();
            Strategy strategy = inputProcessor.GetStrategy("a");
            Assert.AreEqual(Strategy.Switch, strategy);
        }

        [TestMethod()]
        public void GetStrategyKeepTest()
        {
            InputProcessor inputProcessor = new InputProcessor();
            Strategy strategy = inputProcessor.GetStrategy("b");
            Assert.AreEqual(Strategy.Keep, strategy);
        }

        [TestMethod()]
        public void GetStrategyBothTest()
        {
            InputProcessor inputProcessor = new InputProcessor();
            Strategy strategy = inputProcessor.GetStrategy("c");
            Assert.AreEqual(Strategy.Both, strategy);
        }

        [TestMethod()]
        public void GetStrategyUpperCaseTest()
        {
            InputProcessor inputProcessor = new InputProcessor();
            Strategy strategy = inputProcessor.GetStrategy("A");
            Assert.AreEqual(Strategy.Switch, strategy);
        }

        [TestMethod()]
        public void GetStrategyDefaultTest()
        {
            InputProcessor inputProcessor = new InputProcessor();
            Strategy strategy = inputProcessor.GetStrategy("x");
            Assert.AreEqual(Strategy.None, strategy);
        }
    }
}