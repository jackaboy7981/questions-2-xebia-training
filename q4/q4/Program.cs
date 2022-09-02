using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Input a Year: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a%4 == 0) {
                Console.WriteLine(a + " is a leap year");
            }
            else
            {
                Console.WriteLine(a + " is not a leap year");
            }
            Console.ReadKey();
        }
    }
}
