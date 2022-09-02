using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter the number : ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(a + " x " + i + "=" + (a * i));
            }
            Console.ReadKey();
        }
    }
}
