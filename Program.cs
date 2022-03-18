using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForfrontConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            
            // instance of Ractangle
            var ractangle = new Ractangle();

            //Read Ractangle
            string[] TopRightCordinate = Console.ReadLine().Split(' ');
            if (TopRightCordinate.Count() == 2)
            {
                ractangle.TopRight.x = Convert.ToInt16(TopRightCordinate[0]);
                ractangle.TopRight.y = Convert.ToInt16(TopRightCordinate[1]);
            }

            // Read Spider locatoin. 
            string[] spiderCordinate = Console.ReadLine().Split(' ');
            if (spiderCordinate.Count() == 3   )
            ractangle.PositionSpider(Convert.ToInt16(spiderCordinate[0]), Convert.ToInt16(spiderCordinate[1]), Convert.ToString(spiderCordinate[2]));

            // Loop thru transaction.
            for (int i = 0; i <= 10; i++) {
                ractangle.MovesSpider(readkey());
            }

            ractangle.Spider.displayPosition();

            }
            catch (Exception)
            {
                Console.WriteLine("some thing wrong...Try with correct data.");
                readkey();
            }
           
        }

        /// <summary>
        /// input character
        /// </summary>
        /// <returns></returns>
        public static string readkey() {
            return Console.ReadKey().KeyChar.ToString(); 
        }
    }
   
}
