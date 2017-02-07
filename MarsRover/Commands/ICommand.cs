using System;

namespace MarsRover.Commands
{
    public interface ICommand
    {
        void Execute(Rover rover);
    }
}
