using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHallApp;
using MontyHallApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MontyHallApp.Tests
{
    [TestClass()]
    public class GameSummaryTests
    {
        [TestMethod()]
        public void ShowTest()
        {
            Summary summary = new Summary();
            summary.NumberOfSimulations = 10;
            summary.SwitchedDoorCount = 3;
            summary.TotalWinningCount = 4;
            summary.WinningPercentage = "70 %";
            GameSummary gameSummary = new GameSummary();

            string expectedOutput = "\r\n ----------------------------------------------\r\nResults of Monty Hall Problem Simulation\r\n ----------------------------------------------\r\n\r\nTotal Number of Simulations : 10\r\nTotal Winning Attempts : 4\r\nPercentage of Winning : 70 %\r\nTotal Switched Doors : 3\r\n\r\n\r\n";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            gameSummary.Show(summary);

            string actualOutput = stringWriter.ToString();
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}