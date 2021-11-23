using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHallApp.Enums
{
    public class Enums
    {
        public enum Strategy
        {
            Switch,
            Keep,
            Both,
            None
        }

        public enum DoorNumber
        {
            Door1 = 1,
            Door2 = 2,
            Door3 = 3
        }

        public enum StrategySelection
        {
            a,
            b,
            c
        }

        public enum Exit
        { 
            exit,
            quit
        }
    }
}
