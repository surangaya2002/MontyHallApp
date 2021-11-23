using MontyHallApp.Interfaces;
using MontyHallApp.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp
{
    //class to process input data which is taken from player.
    public class InputProcessor
    {        
        public Strategy GetStrategy(string strategySelection)
        {
            Strategy strategy;
            switch (strategySelection.ToLower())
            {
                case Constants.SwitchValue:
                    strategy = Strategy.Switch;
                    break;
                case Constants.KeepValue:
                    strategy = Strategy.Keep;
                    break;
                case Constants.BothValue:
                    strategy = Strategy.Both;
                    break;
                default:                   
                    strategy = Strategy.None;
                    break;
            }
            return strategy;
        }
    }
}
