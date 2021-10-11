using System;
using ToyRobotSimulator.src.model;

namespace ToyRobotSimulator.src.Extras
{
    public  class BoardOutputter
    {
        protected Board board;

        public BoardOutputter(Board board)
        {
            this.board = board;
        }

        public  string STRING()
        {
            Utils.DirectionCode currentPostion = board.GetCurrentDirection();
            int currentX = board.GetCurrentX();
            int currentY = board.GetCurrentY();

            return $"Output: {currentX},{currentY}{Utils.GetDirectionName(currentPostion)}";
        }
        public  string JSON()
        {
            return "{}";

        }
        public  string HTML()
        {
            return "<html></html>";
        }
    }
}
