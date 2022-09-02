using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Input the value for X coordinate : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate : ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x>0 && y>0)
            {
            Console.Write("The coordinate point("+x+", "+y+") lies in the First quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.Write("The coordinate point(" + x + ", " + y + ") lies in the Fourth quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.Write("The coordinate point(" + x + ", " + y + ") lies in the Second quadrant");
            }
            else
            {
                Console.Write("The coordinate point(" + x + ", " + y + ") lies in the Third quadrant");
            }
            Console.ReadKey();
        }
    }
}
