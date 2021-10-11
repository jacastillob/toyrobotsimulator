using System;
using System.Collections.Generic;

namespace ToyRobotSimulator.src.model
{
    public class Board
    {
        private int width;
        private int height;
        private int currentIndex;

        private Utils.DirectionCode[] positions;
        
        public Board()
        {
        }
        public void Initialize(int width,int height)
        {
            this.width = width;
            this.height = height;
            positions = new Utils.DirectionCode[width*height];
        }

        public Utils.DirectionCode[] GetPositions()
        {
            return positions;
        }

        private bool IsValidNewPosition(int x, int y)
        {
            if (x > this.width || y > this.height)
                return false;
            if (x < 0 || y < 0)
                return false;

            return true;

        }
        public  bool Place(int x, int y, Utils.DirectionCode Direction)
        {
            if (!IsValidNewPosition(x,y)) return false;

            currentIndex = GetBoardIndex(x, y);
            positions[currentIndex] = Direction;

            return true;
        }

        public int[] Move()
        {
            int currentX = this.GetX(this.currentIndex);
            int currentY = this.GetY(this.currentIndex);
            
                switch (positions[this.currentIndex])
                {

                    // DECREASE X -> Heading NORTH
                    case Utils.DirectionCode.NORTH:
                    if (IsValidNewPosition(++currentX, currentY))
                        {
                            positions[currentIndex] = Utils.DirectionCode.NONE;
                            currentIndex = GetBoardIndex(currentX, currentY);
                            positions[currentIndex] = Utils.DirectionCode.NORTH;
                        }
                    break;
                    // INCREASE X -> Heading SOUTH
                    case Utils.DirectionCode.SOUTH:
                    if (IsValidNewPosition(--currentX, currentY))
                        {
                            positions[currentIndex] = Utils.DirectionCode.NONE;
                            currentIndex = GetBoardIndex(currentX, currentY);
                            positions[currentIndex] = Utils.DirectionCode.SOUTH;
                        }
                    break;
                    // DECREASE Y -> Heading WEAST
                    case Utils.DirectionCode.WEST:
                    if (IsValidNewPosition(currentX, ++currentY))
                        {
                            positions[currentIndex] = Utils.DirectionCode.NONE;
                            currentIndex = GetBoardIndex(currentX, currentY);
                            positions[currentIndex] = Utils.DirectionCode.WEST;
                        }
                    break;
                    // INCREASE Y -> Heading EAST
                    case Utils.DirectionCode.EAST:
                    if (IsValidNewPosition(currentX, --currentY))
                        {
                            positions[currentIndex] = Utils.DirectionCode.NONE;
                            currentIndex = GetBoardIndex(currentX, currentY);
                            positions[currentIndex] = Utils.DirectionCode.EAST;
                        }
                    break;
                }
            return new int[] {currentX,currentY };
        }


        public Utils.DirectionCode Left()
        {
            switch (positions[this.currentIndex])
            {

                case Utils.DirectionCode.NORTH:
                    positions[currentIndex] = Utils.DirectionCode.WEST;
                break;
                case Utils.DirectionCode.WEST:
                    positions[currentIndex] = Utils.DirectionCode.SOUTH;
                    break;
                case Utils.DirectionCode.SOUTH:
                    positions[currentIndex] = Utils.DirectionCode.EAST;
                    break;
                case Utils.DirectionCode.EAST:
                    positions[currentIndex] = Utils.DirectionCode.NORTH;
                    break;
            }

            return positions[currentIndex];

        }

        public Utils.DirectionCode Right()
        {
            switch (positions[this.currentIndex])
            {

                case Utils.DirectionCode.NORTH:
                    positions[currentIndex] = Utils.DirectionCode.EAST;
                    break;
                case Utils.DirectionCode.EAST:
                    positions[currentIndex] = Utils.DirectionCode.SOUTH;
                    break;
                case Utils.DirectionCode.SOUTH:
                    positions[currentIndex] = Utils.DirectionCode.WEST;
                    break;
                case Utils.DirectionCode.WEST:
                    positions[currentIndex] = Utils.DirectionCode.NORTH;
                    break;
            }

            return positions[currentIndex];
        }

        /// <summary>
        /// Return index using x and y requested
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private int GetBoardIndex(int x, int y)
        {
            return y * this.width + x;
        }
        private int GetX(int index)
        {
            return index % this.width;
        }
        private int GetY(int index)
        {
            return index / this.width;
        }
        
        public Utils.DirectionCode GetCurrentDirection()
        {
            return positions[this.currentIndex];
        }
        public int GetCurrentX()
        {
            return GetX(this.currentIndex);
        }
        public int GetCurrentY()
        {
            return GetY(this.currentIndex);
        }
    }
}
