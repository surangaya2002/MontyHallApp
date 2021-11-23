using MontyHallApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHallApp
{
    //class to generate random number
    public class RandomNumberGenerator : IGenerator
    {
        public int GenerateRandomNumber(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue);
        }
    }
}
