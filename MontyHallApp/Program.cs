using Microsoft.Extensions.DependencyInjection;
using MontyHallApp.Interfaces;
using MontyHallApp.Models;
using MontyHallApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using static MontyHallApp.Enums.Enums;

namespace MontyHallApp
{
    class Program
    {    
        static void Main(string[] args)
        {
            //inject dependencies.
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IGameProcessor, GameProcessor>()
            .AddSingleton<IGenerator, RandomNumberGenerator>()
            .AddSingleton<IGameSummary, GameSummary>()
            .BuildServiceProvider();

            Validator validations = new Validator();
            InputProcessor inputProcessor = new InputProcessor();

            try
            {
                bool isPlayGame = true;
                while (isPlayGame)
                {
                    Console.WriteLine(Constants.GameIntro);

                    //read, validate and get user strategy.
                    string strategySelection = Console.ReadLine();
                    bool isValidStrategy = validations.IsValidStrategy(strategySelection);
                    while (!isValidStrategy)
                    {
                        Console.WriteLine(Constants.IncorrrectStrategy);
                        strategySelection = Console.ReadLine();
                        isValidStrategy = validations.IsValidStrategy(strategySelection);
                    }
                    Strategy strategy = inputProcessor.GetStrategy(strategySelection);

                    //read validate and get simulation count.
                    Console.WriteLine(Constants.SimulationInfo);
                    string expectedSimulationCount = Console.ReadLine();
                    bool isValidSimulationCount = validations.IsValidSimulationCount(expectedSimulationCount);
                    while (!isValidSimulationCount)
                    {
                        Console.WriteLine(Constants.IncorrectSimulation);
                        expectedSimulationCount = Console.ReadLine();
                        isValidSimulationCount = validations.IsValidSimulationCount(expectedSimulationCount);
                    }
                    int simulationCount = int.Parse(expectedSimulationCount);

                    var gameProcessor = serviceProvider.GetService<IGameProcessor>();
                    var gameSummary = serviceProvider.GetService<IGameSummary>();
                    //initialize and play game.
                    Game game = new Game(strategy, simulationCount, gameProcessor);
                    Summary summary = game.Play();
                    gameSummary.Show(summary);

                    Console.WriteLine(Constants.Exit);
                    string stop = Console.ReadLine();
                    isPlayGame = game.Stop(stop);
                }
            }
            catch (Exception exception)
            {
                //log the 'exception' using log4net or any other logging framework
                Console.WriteLine(Constants.GameError);
            }
            
        }       
    }
}
