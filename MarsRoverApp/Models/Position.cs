using MarsRoverApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp.Models
{
    public class Position : IPosition
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}
