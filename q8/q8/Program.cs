using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter first Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second Number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third Number : ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if(a>c)
                {
                    Console.WriteLine("First number is the greatest");
                }
                else
                {
                    Console.WriteLine("Third number is the greatest");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Second number is the greatest");
                }
                else
                {
                    Console.WriteLine("Third number is the greatest");
                }
            }
            Console.ReadKey();

        }
    }
}
