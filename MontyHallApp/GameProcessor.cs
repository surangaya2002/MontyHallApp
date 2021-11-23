using MontyHallApp.Interfaces;
using MontyHallApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp
{
    //class to process according to input while playing.
    public class GameProcessor : IGameProcessor
    {
        public IGenerator Generator { get; set; }

        public GameProcessor(IGenerator generator)
        {
            this.Generator = generator;
        }

        //process game input and set properties.
        public Result Process(Strategy strategy)
        {
            List<Door> doors = GetDoorList();
            ApplyStratergy(strategy, doors);
            Result result = GetResults(doors);

            return (result);
        }

        //create door list and randomly set each door values.
        private List<Door> GetDoorList()
        {
            Door door1 = new Door { Number = DoorNumber.Door1 };
            Door door2 = new Door { Number = DoorNumber.Door2 };
            Door door3 = new Door { Number = DoorNumber.Door3 };

            List<Door> doors = new List<Door>();
            doors.Add(door1);
            doors.Add(door2);
            doors.Add(door3);

            int winningDoorNumber = Generator.GenerateRandomNumber(1, 4);
            doors[winningDoorNumber - 1].IsWinningDoor = true;

            int firstChoiceDoorNumber = Generator.GenerateRandomNumber(1, 4);
            doors[firstChoiceDoorNumber - 1].IsFirstChoice = true;

            foreach (Door door in doors)
            {
                if (!door.IsFirstChoice && !door.IsWinningDoor)
                {
                    door.IsMontySelected = true;
                    break;
                }
            }

            return doors;
        }

        //handle door property values according to the strategy
        private void ApplyStratergy(Strategy strategy, List<Door> doors)
        {
            if (strategy == Strategy.Both)
                strategy = (Strategy)Generator.GenerateRandomNumber(0, 2);

            if (strategy == Strategy.Switch)
            {
                foreach (Door door in doors)
                {
                    if (!door.IsFirstChoice && !door.IsMontySelected)
                    {
                        door.IsSecondChoice = true;
                        break; 
                    }
                }
            }

            else if (strategy == Strategy.Keep)
            {
                foreach (Door door in doors)
                {
                    if (door.IsFirstChoice)
                        door.IsSecondChoice = door.IsFirstChoice;
                }
            }
        }

        //results which indicate player wins after switch door.
        private Result GetResults(List<Door> doors)
        {
            Result result = new Result();
            foreach (Door door in doors)
            {
                if (door.IsSecondChoice)
                {
                    result.IsPlayerSwitchedDoor = !door.IsFirstChoice;
                    result.IsPlayerWins = door.IsWinningDoor;
                }
            }

            return result;
        }   
    }
}
