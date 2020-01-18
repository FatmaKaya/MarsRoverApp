﻿using MarsRoverApp.Enums;
using MarsRoverApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp.Models
{
    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public IPosition RoverPosition { get; set; }
        public Directions RoverDirection { get; set; }


        public Rover(IPlateau roverPlateau, IPosition roverPosition, Directions roverDirection)
        {
            RoverPlateau = roverPlateau;
            RoverPosition = roverPosition;
            RoverDirection = roverDirection;
        }

        public void Process(string commands)
        {
            foreach (Command command in commands)
            {
                switch (command)
                {
                    case Command.Left:
                        TurnLeft();
                        break;
                    case Command.Right:
                        TurnRight();
                        break;
                    case Command.Move:
                        MoveForward();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command.ToString()));
                }
            }
        }
        private void TurnLeft()
        {
            RoverDirection = RoverDirection == Directions.S ? RoverDirection = Directions.E : RoverDirection + 90;
        }

        private void TurnRight()
        {
            RoverDirection = RoverDirection == Directions.E ? RoverDirection = Directions.S : RoverDirection - 90;
        }

        private void MoveForward()
        {
            if (RoverDirection == Directions.N)
            {
                RoverPosition.YCoordinate++;
            }
            else if (RoverDirection == Directions.E)
            {
                RoverPosition.XCoordinate++;
            }
            else if (RoverDirection == Directions.S)
            {
                RoverPosition.YCoordinate--;
            }
            else if (RoverDirection == Directions.W)
            {
                RoverPosition.XCoordinate--;
            }
        }

        public string CurrentLocation()
        {
             return string.Format("{0} {1} {2}", RoverPosition.XCoordinate, RoverPosition.YCoordinate, RoverDirection);
        }
    }
}