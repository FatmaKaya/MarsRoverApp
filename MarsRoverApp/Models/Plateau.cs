using MarsRoverApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp.Models
{
    public class Plateau : IPlateau
    {
        public Position PlateauPosition { get; private set; }
        public Plateau(Position position)
        {
            PlateauPosition = position;
        }
    }
}
