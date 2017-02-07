using MarsRover.Commands;
using MarsRover.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public static class UtilEnums
    {
        static IDictionary<CommandTypes, ICommand> CommandMapping;
        static IDictionary<Directions, IDirection> DirectionMapping;

        static UtilEnums()
        {
            CommandMapping = new Dictionary<CommandTypes, ICommand>();
            DirectionMapping = new Dictionary<Directions, IDirection>();
            LoadCommandMapping();
            LoadDirectionMapping();
        }

        enum CommandTypes
        {
            L = 'L',
            R = 'R',
            M = 'M'
        }

        enum Directions
        {
            N = 'N',
            S = 'S',
            W = 'W',
            E = 'E'
        }

        private static void LoadCommandMapping()
        {
            CommandMapping.Add(CommandTypes.L, new SpinLeft());
            CommandMapping.Add(CommandTypes.R, new SpinRight());
            CommandMapping.Add(CommandTypes.M, new MoveForward());
        }

        private static void LoadDirectionMapping()
        {
            DirectionMapping.Add(Directions.N, new NorthDirection());
            DirectionMapping.Add(Directions.S, new SouthDirection());
            DirectionMapping.Add(Directions.W, new WestDirection());
            DirectionMapping.Add(Directions.E, new EastDirection());
        }

        public static IDirection getMappedDirection(char dir)
        {
            if (DirectionMapping.ContainsKey((Directions)dir))
            {
                return DirectionMapping[(Directions)dir];
            }

            return null;
        }


        public static ICommand getMappedCommand(char cmd)
        {
            if (CommandMapping.ContainsKey((CommandTypes)cmd))
            {
                return CommandMapping[(CommandTypes)cmd];
            }

            return null;
        }

    }
}
