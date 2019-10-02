using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_loops_for_while_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine($"WHILE {i}");
                i++;
            }

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"FOR {j}");
            }
        }
    }
}
