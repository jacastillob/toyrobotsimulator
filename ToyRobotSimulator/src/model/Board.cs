using System;
using System.Collections.Generic;

namespace ToyRobotSimulator.src.model
{
    public class Board
    {

        private int[] positions;
        private int width, height; 
        public Board()
        {
        }
        public void Initialize(int width,int height)
        {
            this.width = width;
            this.height = height;

            positions = new int[width*height];
        }

        public  int[] GetPositions()
        {
            return positions;
        }

        public  bool Place(int x, int y, int v)
        {
            positions[x * y] = v;
            return true;
        }

        public int[] Move()
        {
            throw new NotImplementedException();
        }
    }
}
