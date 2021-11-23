using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHallApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHallApp.Tests
{
    [TestClass()]
    public class RandomNumberGeneratorTests
    {
        [TestMethod()]
        public void GenerateRandomNumberTest()
        {
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            int randomNumber = randomNumberGenerator.GenerateRandomNumber(0, 3);
            Assert.IsTrue(randomNumber >= 0 && randomNumber <= 3);
        }
    }
}