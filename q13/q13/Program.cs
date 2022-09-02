using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter the number : ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                for (int j =1; j<a+1; j++)
                    Console.Write(j + " x " + i + "=" + (j * i)+ "  ");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
