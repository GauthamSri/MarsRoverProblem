using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Plateau
    {
        readonly Position lowerBoundCoords;
        readonly Position upperBoundCoords;


        public Plateau(int upperX, int upperY)
        {
            lowerBoundCoords = new Position(0, 0);
            upperBoundCoords = new Position(upperX, upperY);
        }

        public int getUpperBoundXCoord()
        {
            return upperBoundCoords.xCoordinate;
        }

        public int getUpperBoundYCoord()
        {
            return upperBoundCoords.yCoordinate;
        }

        public int getLowerBoundXCoord()
        {
            return lowerBoundCoords.xCoordinate;
        }

        public int getLowerBoundYCoord()
        {
            return lowerBoundCoords.yCoordinate;
        }
    }
}
