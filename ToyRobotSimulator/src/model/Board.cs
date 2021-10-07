using System;
using System.Collections.Generic;

namespace ToyRobotSimulator.src.model
{
    public class Board
    {

        private int[] positions;
        
        public Board()
        {
        }
        public void Initialize(int width,int height)
        {
            positions = new int[width*height];
        }

        public  int[] GetPositions()
        {
            return positions;
        }

        public  bool Place(int x, int y, int Direction)
        {
            positions[x * y] = Direction;
            return true;
        }

        public int[] Move()
        {

            for (int i = 0; i < positions.Length; i++)
            {
               
            }

            return new int[] { };
            
        }
    }
}
