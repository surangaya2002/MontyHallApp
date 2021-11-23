using MontyHallApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp.Interfaces
{
    public interface IGameProcessor
    {
        Result Process(Strategy strategy);
    }
}
