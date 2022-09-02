using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Input the value m : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("The value of n = -1");
            }
            else if (a > 0)
            {
                Console.WriteLine("The value of n = 1");
            }
            else
            {
                Console.WriteLine("The value of n = 0");
            }
            Console.ReadKey();
        }
    }
}
