using MarsRoverApp.Enums;
using MarsRoverApp.Models;
using System;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverUnitTest
    {
        [Fact]
        public void Rover1TrueOutput()
        {
            string actualOutpu = "1 3 N";
            Plateau plateau = new Plateau(new Position(5, 5));
            Rover Rover = new Rover(plateau, new Position(1, 2), Directions.N);
            Rover.Process("LMLMLMLMM");
            string expectedOutpu = Rover.CurrentLocation();

            Assert.Equal(expectedOutpu, actualOutpu);
        }

        [Fact]
        public void Rover1FalseOutput()
        {
            string actualOutpu = "1 3 N";
            Plateau plateau = new Plateau(new Position(5, 5));
            Rover Rover = new Rover(plateau, new Position(1, 2), Directions.N);
            Rover.Process("LRLRLMRMR");
            string expectedOutpu = Rover.CurrentLocation();

            Assert.NotEqual(expectedOutpu, actualOutpu);
        }

        [Fact]
        public void Rover2TrueOutput()
        {
            string actualOutpu = "5 1 E";
            Plateau plateau = new Plateau(new Position(5, 5));
            Rover Rover = new Rover(plateau, new Position(3, 3), Directions.E);
            Rover.Process("MMRMMRMRRM");
            string expectedOutpu = Rover.CurrentLocation();

            Assert.Equal(expectedOutpu, actualOutpu);
        }

        [Fact]
        public void Rover2FalseOutput()
        {
            string actualOutpu = "5 1 E";
            Plateau plateau = new Plateau(new Position(5, 5));
            Rover Rover = new Rover(plateau, new Position(3, 1), Directions.E);
            Rover.Process("MMRMMRMRRM");
            string expectedOutpu = Rover.CurrentLocation();

            Assert.NotEqual(expectedOutpu, actualOutpu);
        }

    }
}
