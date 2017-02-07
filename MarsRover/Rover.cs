using MarsRover.Commands;
using MarsRover.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        Position currentPosition;
        Plateau plateau;
        IDirection direction;

        public Rover(Plateau _plateau, Position _position, IDirection _direction)
        {
            this.currentPosition = _position;
            this.plateau = _plateau;
            this.direction = _direction;
        }

       public Position getCurrentPosition()
        {
            return this.currentPosition;
        }

        public void setCurrentPosXcoord(int x)
        {
            currentPosition.xCoordinate = x;
        }

        public void setCurrentPosYcoord(int y)
        {
            currentPosition.yCoordinate = y;
        }

        public IDirection getRoverDirection()
        {
            return this.direction;
        }

        public void setRoverDirection(IDirection newDirection)
        {
            this.direction = newDirection;
        }

        public void spinRight()
        {
            this.direction = getRoverDirection().spinRight();
        }

        public void spinLeft()
        {
            this.direction = getRoverDirection().spinLeft();
        }

        public void moveForward()
        {
            getRoverDirection().moveForward(this);
            //If rover moves out of bound, undo the move
            if(this.isRoverOutOfBound())
                getRoverDirection().moveBackward(this);
        }


        public void executeCommands(List<ICommand> commands)
        {
            foreach(var command in commands)
            {
                command.Execute(this);
            }
        }

        public string getPositionAndDirection()
        {
            return this.currentPosition.xCoordinate + " " + this.currentPosition.yCoordinate + " " + this.direction.getDirectionLetter();
        }

        public bool isRoverOutOfBound()
        {
            if (this.getCurrentPosition().xCoordinate > this.plateau.getUpperBoundXCoord()
                || this.getCurrentPosition().yCoordinate > this.plateau.getUpperBoundYCoord()
                || this.getCurrentPosition().xCoordinate < this.plateau.getLowerBoundXCoord()
                || this.getCurrentPosition().yCoordinate < this.plateau.getLowerBoundYCoord())
                return true;
            else
                return false;
        }
    }
}
