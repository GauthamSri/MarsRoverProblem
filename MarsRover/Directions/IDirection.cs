using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Directions
{
    public interface IDirection
    {
        IDirection spinRight();
        IDirection spinLeft();
        void moveForward(Rover rover);
        void moveBackward(Rover rover);
        string getDirectionLetter();

    }
}
