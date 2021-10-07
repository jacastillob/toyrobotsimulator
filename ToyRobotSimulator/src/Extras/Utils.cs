using System;
using System.Collections.Generic;

namespace ToyRobotSimulator.src
{
    public static class Utils
    {
       static Dictionary<string,int> dire = new Dictionary<string, int>() { {"NORTH",0}, { "SOUTH", 2 }, { "EAST", 3 }, { "WEST", 4 } };

        enum ErrorCode : uint
        {
            NORTH = 0,
            SOUTH = 2,
            EAST = 3,
            WEST = 4
        }

        public static int GetDirection(string direction)
        {

            return dire[direction];
        }
    }

      


    
}
