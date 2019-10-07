using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_2017_09_IC_loops_do_while_AddCalcPlayMany
{
    class Program
    {
        static void Main(string[] args)
        {
            String playAgain = "y";
            String stringEntered = "1";
            double numEntered;
            double total = 0;

            Console.WriteLine($"*** Welcome to the Adding Machine. ***");
            do {
                Console.WriteLine($"Enter = when done.");
                while (stringEntered != "="){
                    Console.Write($"Enter a number: ");
                    stringEntered = Console.ReadLine();
                    if (stringEntered != "="){
                        numEntered = double.Parse(stringEntered);
                        total += numEntered;
                    }
                }
                stringEntered = "1";
                Console.WriteLine($"The total is {total}");
                total = 0;
                Console.Write($"Would you like to play again y or n? ");
                playAgain = Console.ReadLine();
            } while (playAgain != "n");

        }
    }
}
