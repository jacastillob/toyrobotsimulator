using System;
using System.Collections.Generic;

namespace ToyRobotSimulator.src
{
    public static class Utils
    {

        public enum DirectionCode : int
        {
            NONE = 0,
            NORTH = 1,
            SOUTH = 2,
            EAST = 3,
            WEST = 4
        }

        private static Dictionary<string, DirectionCode> DIRECTIONS = new Dictionary<string, DirectionCode>()
        {   { "NORTH", DirectionCode.NORTH },
            { "SOUTH", DirectionCode.SOUTH },
            { "EAST", DirectionCode.EAST },
            { "WEST", DirectionCode.WEST } };

        public static DirectionCode GetDirection(string direction)
        {

            return DIRECTIONS[direction];
        }

    }
}
