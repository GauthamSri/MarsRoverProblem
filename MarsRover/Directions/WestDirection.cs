using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Directions
{
    public class WestDirection : IDirection
    {
        public void moveBackward(Rover rover)
        {
            rover.setCurrentPosXcoord(rover.getCurrentPosition().xCoordinate + 1);
        }

        public void moveForward(Rover rover)
        {
            rover.setCurrentPosXcoord(rover.getCurrentPosition().xCoordinate - 1);
        }

        public IDirection spinLeft()
        {
            return new SouthDirection();
        }

        public IDirection spinRight()
        {
            return new NorthDirection();
        }

        //for simplicity not using direction Enums
        public string getDirectionLetter()
        {
            return "W";
        }
    }
}
