using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHallApp.Utils
{
    //class to store constant files.
    public class Constants
    {
        #region Info Messages

        public const string GameIntro = "What strategy do you want to play ? Select A B or C and press Enter\r\nA) Always switch the door\r\nB) Never switch the door\r\nC) Both";
        public const string SimulationInfo = "How many simulations do you want to run ?";
        public const string ResultsHeader = "\r\n ----------------------------------------------\r\nResults of Monty Hall Problem Simulation\r\n ----------------------------------------------\r\n";
        public const string TotalSimulations = "Total Number of Simulations : {0}";
        public const string TotalWins = "Total Winning Attempts : {0}";
        public const string WinPercentage = "Percentage of Winning : {0}";
        public const string TotalSwitches = "Total Switched Doors : {0}";
        public const string Seperator = "\r\n";
        public const string Exit = "Hit any key to continue or enter ‘Exit’ to quit.";

        #endregion

        #region Error Messages

        public const string IncorrrectStrategy = "Incorrect choice. Please enter valid strategy";
        public const string IncorrectSimulation = "Please Enter valid number of simulations that you want to execute";
        public const string GameError = "Error occured. Please restart the game.";

        #endregion

        #region Constant values

        public const string SwitchValue = "a";
        public const string KeepValue = "b";
        public const string BothValue = "c";

        public const string ExitValue = "exit";
        public const string QuitValue = "quit";

        public const string PercentageFormat = "0.0 %";

        #endregion
    }
}
