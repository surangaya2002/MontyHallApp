using MontyHallApp.Interfaces;
using MontyHallApp.Models;
using MontyHallApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHallApp
{
    //class to show game summary.
    public class GameSummary : IGameSummary
    {
        public void Show(Summary summary)
        {
            Console.WriteLine(Constants.ResultsHeader);
            Console.WriteLine(Constants.TotalSimulations, summary.NumberOfSimulations);
            Console.WriteLine(Constants.TotalWins, summary.TotalWinningCount);
            Console.WriteLine(Constants.WinPercentage, summary.WinningPercentage);
            Console.WriteLine(Constants.TotalSwitches, summary.SwitchedDoorCount);
            Console.WriteLine(Constants.Seperator);
        }
    }
}
