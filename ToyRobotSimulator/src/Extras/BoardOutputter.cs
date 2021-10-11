using System;
using ToyRobotSimulator.src.model;

namespace ToyRobotSimulator.src.Extras
{
    public static class BoardOutputter
    {

        public static string STRING(Board board )
        {
            Utils.DirectionCode currentPostion = board.GetCurrentDirection();
            int currentX = board.GetCurrentX();
            int currentY = board.GetCurrentY();

            return $"Output: {currentX},{currentY}{Utils.GetDirectionName(currentPostion)}";

        }
        public static string JSON(Board board)
        {
            return "{}";

        }
        public static string HTML(Board board)
        {
            return "<html></html>";

        }
    }
}
