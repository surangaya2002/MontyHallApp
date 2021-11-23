using MontyHallApp.Interfaces;
using MontyHallApp.Models;
using MontyHallApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp
{
    //game class which incluse methods related to game.
    public class Game
    {
        public IGameProcessor GameProcessor { get; set; }
        public Strategy Strategy { get; set; }
        public int NumberOfSimulations { get; set; }

        //constructor
        public Game(Strategy strategy, int numberOfSimulations, IGameProcessor gameProcessor)
        {
            this.Strategy = strategy;
            this.NumberOfSimulations = numberOfSimulations;
            this.GameProcessor = gameProcessor;
        }

        //play the game.
        public Summary Play()
        {
            List<Result> results = new List<Result>();
            for (int simulation = 0; simulation < NumberOfSimulations; simulation++)
            {
                results.Add(GameProcessor.Process(Strategy));
            }

            var winningCountList = from result in results
                                   where result.IsPlayerWins
                                   select result;

            var switchDoorCountList = from result in results
                                      where result.IsPlayerSwitchedDoor
                                      select result;

            int switchedDoorCount = switchDoorCountList.Count();
            int totalWinningCount = winningCountList.Count();
            decimal winningPercentage = (decimal)totalWinningCount / (decimal)NumberOfSimulations;

            Summary summary = new Summary();
            summary.NumberOfSimulations = NumberOfSimulations;
            summary.TotalWinningCount = totalWinningCount;
            summary.WinningPercentage = winningPercentage.ToString(Constants.PercentageFormat);
            summary.SwitchedDoorCount = switchedDoorCount;

            return summary;
        }

        //stop the game.
        public bool Stop(string stopValue)
        {
            bool isPlay = true;
            switch (stopValue.ToLower())
            {
                case Constants.ExitValue:
                case Constants.QuitValue:
                    isPlay = false;
                    break;
            }

            return isPlay;
        }
    }
}
