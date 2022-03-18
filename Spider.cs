using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForfrontConsole
{
   
    public class Spider : Coordinate
    {
        public Spider()
        {
            Orientation = 0;
        }

        private int Orientation { get; set; }
        /// <summary>
        /// Rotate directon when enter R or L
        /// </summary>
        /// <param name="direction"></param>
        private void Spin(string direction)
        {
            switch (direction.ToUpper())
            {
                case "LEFT":
                    Orientation = 0;
                    break;
                case "TOP":
                    Orientation = 90;
                    break;
                case "RIGHT":
                    Orientation = 180;
                    break;
                case "BOTTOM":
                    Orientation = 270;
                    break;
                case "L":
                    Orientation = Orientation == 0 ? Orientation = 270 : Orientation -= 90;
                    break;
                case "R":
                    Orientation = Orientation == 270 ? Orientation = 0 : Orientation += 90;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Get direction of spider
        /// </summary>
        /// <returns></returns>
        public string GetDirection()
        {

            switch (Orientation)
            {
                case 0:
                    return OrientationEnum.LEFT.ToString();
                case 90:
                    return OrientationEnum.TOP.ToString();
                case 180:
                    return OrientationEnum.RIGHT.ToString();
                case 270:
                    return OrientationEnum.BOTTOM.ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// Move spider location.
        /// </summary>
        /// <param name="direction"></param>
        public void Move(string direction)
        {
            Spin(direction);
            if (direction == "F")
            {
                if (Orientation == 0)
                    this.x -= 1;
                else if (Orientation == 90)
                    this.y += 1;
                else if (Orientation == 180)
                    this.x += 1;
                else if (Orientation == 270)
                    this.y -= 1;
            }
        }

        /// <summary>
        /// Display Result
        /// </summary>
        public void displayPosition()
        {
            Console.WriteLine("\n{0} {1} {2} ", this.x, this.y, GetDirection());
            Console.ReadKey();
        }

        /// <summary>
        /// Set position for x and y initially.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="direction"></param>
        public void SetPosition(int x, int y, string direction)
        {
            this.x = x;
            this.y = y;
            Spin(direction);
        }
    }
    public enum OrientationEnum
    {
        LEFT,
        TOP,
        RIGHT,
        BOTTOM
    }
}
