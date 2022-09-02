using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(a+" ");
                    a++;
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
