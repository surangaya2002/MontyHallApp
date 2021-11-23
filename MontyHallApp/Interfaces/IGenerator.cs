using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHallApp.Interfaces
{
    public interface IGenerator
    {
        public int GenerateRandomNumber(int minValue, int maxValue);
    }
}
