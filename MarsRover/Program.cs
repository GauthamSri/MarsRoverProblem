using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            input.Add("5 5");
            input.Add("1 2 N");
            input.Add("LMLMLMLMM");
            input.Add("3 3 E");
            input.Add("MMRMMRMRRM");

            InputParser parser = new InputParser();

            //Didn't focus on validating inputs and correctly looping through input strings and parsing and extracting

            Plateau plateau = parser.parsePlateau(input[0]);
            Rover rover1 = parser.parseRoverPosition(input[1], plateau);
            rover1.executeCommands(parser.parseCommands(input[2]));

            Console.WriteLine(rover1.getPositionAndDirection());

            Rover rover2 = parser.parseRoverPosition(input[3], plateau);
            rover2.executeCommands(parser.parseCommands(input[4]));

            Console.WriteLine(rover2.getPositionAndDirection());

            Console.Read();


        }
    }
}
