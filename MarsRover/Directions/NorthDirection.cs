using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Directions
{
    public class NorthDirection : IDirection
    {
        public void moveBackward(Rover rover)
        {
            rover.setCurrentPosYcoord(rover.getCurrentPosition().yCoordinate - 1);
        }

        public void moveForward(Rover rover)
        {
            rover.setCurrentPosYcoord(rover.getCurrentPosition().yCoordinate + 1);
        }

        public IDirection spinLeft()
        {
            return new WestDirection();
        }

        public IDirection spinRight()
        {
            return new EastDirection();
        }

        //for simplicity not using direction Enums
        public string getDirectionLetter()
        {
            return "N";
        }
    }
}
