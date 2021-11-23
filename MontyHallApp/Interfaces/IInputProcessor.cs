using System;
using System.Collections.Generic;
using System.Text;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp.Interfaces
{
    public interface IInputProcessor
    {
        public Strategy GetStrategy();

        public int GetNumberOfSimulations();
    }
}
