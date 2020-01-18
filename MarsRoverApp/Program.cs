using MarsRoverApp.Enums;
using MarsRoverApp.Models;
using System;

namespace MarsRoverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTestInputMessage();

            string rover1Location = CreateRover(new Position(5, 5), new Position(1, 2), Directions.N, "LMLMLMLMM");
            string rover2Location = CreateRover(new Position(5, 5), new Position(3, 3), Directions.E, "MMRMMRMRRM");

            Console.WriteLine("------ Outputs ------");
            Console.WriteLine();
            GetOutputtMessage("Rover 1", rover1Location);
            GetOutputtMessage("Rover 2", rover2Location);

            Console.ReadKey();

        }

        static void GetTestInputMessage()
        {
            Console.WriteLine("------ Test Inputs  ------");
            Console.WriteLine();
            
            Console.WriteLine("#Plateau upper-right coordinates : 5 5");
            Console.WriteLine();

            Console.WriteLine("### Rover 1 ");
            Console.WriteLine("-position: 1 2 N");
            Console.WriteLine("-commands: LMLMLMLMM");
            Console.WriteLine();

            Console.WriteLine("### Rover 2 ");
            Console.WriteLine("-position: 3 3 E");
            Console.WriteLine("-commands: MMRMMRMRRM");
            Console.WriteLine();
        }

        static void GetOutputtMessage(string name, string message)
        {   
            Console.Write("#{0} -> ",name);
            Console.WriteLine(message);
        }

        static string CreateRover(Position plateauPosition, Position roverPosition, Directions directions, string commands)
        {
            Plateau plateau = new Plateau(plateauPosition);
            Rover rover = new Rover(plateau, roverPosition, directions);
            rover.Process(commands);
            return rover.CurrentLocation();
        }


    }
}
