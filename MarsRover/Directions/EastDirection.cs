using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Directions
{
    public class EastDirection : IDirection
    {
        public void moveBackward(Rover rover)
        {
            rover.setCurrentPosXcoord(rover.getCurrentPosition().xCoordinate - 1);
        }

        public void moveForward(Rover rover)
        {
            rover.setCurrentPosXcoord(rover.getCurrentPosition().xCoordinate + 1);
        }

        public IDirection spinLeft()
        {
            return new NorthDirection();
        }

        public IDirection spinRight()
        {
            return new SouthDirection();
        }

        //for simplicity not using direction Enums
        public string getDirectionLetter()
        {
            return "E";
        }
    }
}
