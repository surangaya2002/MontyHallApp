using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp
{
    //class to validate input request.
    public class Validator
    {
        //validate user strategy.
        public bool IsValidStrategy(string selectedStrategy)
        {
            bool isValid = false;

            if (!string.IsNullOrEmpty(selectedStrategy))
            {
                List<string> stringList = new List<string>()
                {
                  StrategySelection.a.ToString(),
                  StrategySelection.b.ToString(),
                  StrategySelection.c.ToString()
                };

                isValid = stringList.Any(strategy => strategy.Contains(selectedStrategy));
            }


            return isValid;
        }

        //validate simulation count.
        public bool IsValidSimulationCount(string simulationCount)
        {
            bool isValid = false;
            if(!string.IsNullOrEmpty(simulationCount))
            {
                int numberOfSimulations;
                isValid = int.TryParse(simulationCount, out numberOfSimulations);
            }
            return isValid;
        }
    }
}
