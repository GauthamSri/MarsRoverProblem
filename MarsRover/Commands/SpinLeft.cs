using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Commands
{
    public class SpinLeft : ICommand
    {
        public void Execute(Rover rover)
        {
            rover.spinLeft();
        }
    }
}
