using MarsRover.Commands;
using MarsRover.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class InputParser
    {
        public Plateau parsePlateau(string plateauInput)
        {
            var plateauCoords = plateauInput.Split(' ');

            return new Plateau(Convert.ToInt32(plateauCoords[0]), Convert.ToInt32(plateauCoords[1]));

        }

        public List<ICommand> parseCommands(string cmd)
        {
            var cmds = cmd.ToCharArray();

            List<ICommand> commands = new List<ICommand>();

            foreach( var c in cmds)
            {
                ICommand command = UtilEnums.getMappedCommand(c);
                if (command != null)
                    commands.Add(command);
            }

            return commands;

        }

        public Rover parseRoverPosition(string position, Plateau plateau)
        {
            var input = position.Split(' ');
            Position roverPosition = new Position(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));
            IDirection roverDirection = UtilEnums.getMappedDirection(input[2].ToCharArray()[0]);

            return new Rover(plateau, roverPosition, roverDirection);
        }


    }
}
