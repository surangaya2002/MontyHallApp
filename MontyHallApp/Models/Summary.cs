using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHallApp.Models
{
    public class Summary
    {
        public int NumberOfSimulations { get; set; }
        public int TotalWinningCount { get; set; }
        public string WinningPercentage { get; set; }
        public int SwitchedDoorCount { get; set; }
    }
}
