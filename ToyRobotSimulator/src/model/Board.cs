using System;
using System.Collections.Generic;

namespace ToyRobotSimulator.src.model
{
    public class Board
    {

        private Utils.DirectionCode[] positions;
        
        public Board()
        {
        }
        public void Initialize(int width,int height)
        {
            positions = new Utils.DirectionCode[width*height];
        }

        public Utils.DirectionCode[] GetPositions()
        {
            return positions;
        }

        public  bool Place(int x, int y, Utils.DirectionCode Direction)
        {
            positions[x * y] = Direction;
            return true;
        }

        public int[] Move()
        {

            for (int i = 0; i < positions.Length; i++)
            {

                switch (positions[i])
                {
                    case Utils.DirectionCode.NORTH:

                        break;
                }
                
            }

            return new int[] { };
            
        }

       
    }
}
