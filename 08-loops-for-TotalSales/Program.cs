using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_loops_for_TotalSales
{
    class Program
    {
        static void Main(string[] args)
        {
            int days;
            double sales;
            double totalSales;

            Console.Write("Enter the number of days: ");
            days = int.Parse(Console.ReadLine());

            totalSales = 0;
            for (int i = 1; i <= days; i++)
            {
                Console.Write($"Enter sales as a number for day #{i}: $ ");
                sales = double.Parse(Console.ReadLine());
                totalSales += sales;
            }

            Console.WriteLine($"Total Sales: {totalSales:C}");
        }
    }
}
