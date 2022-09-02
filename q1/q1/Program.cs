using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Input 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write(a+" and "+b+" are ");
            if (a == b)
            {
                Console.Write("equal");
            }
            else
            {
                Console.Write("not equal");
            }
            Console.ReadKey();
        }
    }
}
