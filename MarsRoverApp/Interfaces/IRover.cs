using MarsRoverApp.Enums;
using MarsRoverApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp.Interfaces
{
     public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        IPosition RoverPosition { get; set; }
        Directions RoverDirection { get; set; }
        void Process(string commands);
        string CurrentLocation();
    }
}
