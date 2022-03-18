using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForfrontConsole
{
    public class Ractangle
    {
        public Coordinate BottomLeft { get; set; }
        public Coordinate TopRight { get; set; }
        public Spider Spider { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public Ractangle()
        {
            BottomLeft = new Coordinate();
            TopRight = new Coordinate();
            Spider = new Spider();
            BottomLeft.x = 0;
            BottomLeft.y = 0;
        }
     
        /// <summary>
        /// set initial position for spider
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="Direction"></param>
       public void PositionSpider(int x, int y, string Direction)
        {
            if (x >= BottomLeft.x && x <= TopRight.x && y >= BottomLeft.y && y <= TopRight.y)
            {
                Spider.SetPosition(x, y, Direction);
            }
        }

        /// <summary>
        /// move spider as per input
        /// </summary>
        /// <param name="command"></param>
        public void MovesSpider(string command)
        {
            if (Spider.x >= BottomLeft.x && Spider.x <= TopRight.x && Spider.y >= BottomLeft.y && Spider.y <= TopRight.y)
            {
                Spider.Move(command);
            }
        }
    }
}
