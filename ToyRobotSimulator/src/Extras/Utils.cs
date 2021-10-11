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
        private static Dictionary<string, DirectionCode> DirectionCodes = new Dictionary<string, DirectionCode>()
        {
            { "NORTH", DirectionCode.NORTH },
            { "SOUTH", DirectionCode.SOUTH },
            { "EAST", DirectionCode.EAST },
            { "WEST", DirectionCode.WEST }
        };
        private static Dictionary<DirectionCode, string> DirectionNames = new Dictionary< DirectionCode,string>()
        {
            {  DirectionCode.NORTH,"NORTH" },
            {  DirectionCode.SOUTH,"SOUTH" },
            {  DirectionCode.EAST,"EAST" },
            {  DirectionCode.WEST,"WEST" }
        };
        public static DirectionCode GetDirectionCode(string direction)
        {
            return DirectionCodes[direction];
        }
        public static string GetDirectionName(DirectionCode direction)
        {
            return DirectionNames[direction];
        }
    }
}
