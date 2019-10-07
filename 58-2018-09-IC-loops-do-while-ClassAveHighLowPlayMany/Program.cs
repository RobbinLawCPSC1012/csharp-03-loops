using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_2018_09_IC_loops_do_while_ClassAveHighLowPlayMany
{
    class Program
    {
        static void Main(string[] args)
        {
            double curMark;
            double minMark = 101;
            double maxMark = -1;
            double sumOfMarks = 0;
            double avgMark;
            int numStudents = 1;

            do{
                Console.Write($"Enter mark for student #{numStudents} or 999 to quit the program: ");
                curMark = double.Parse(Console.ReadLine());
                if(curMark >= 0 && curMark <= 100){
                    if (curMark < minMark)
                    {
                        minMark = curMark;
                    }
                    if (curMark > maxMark)
                    {
                        maxMark = curMark;
                    }
                    sumOfMarks += curMark;
                    numStudents++;
                } else if (curMark == 999) {
                    if (sumOfMarks != 0) {
                        avgMark = sumOfMarks / (double)numStudents;
                        Console.WriteLine($"\nAverage Mark: {avgMark}, Highest Mark: {maxMark}, Lowest Mark: {minMark}");
                    }
                } else {
                    Console.WriteLine($"Invalid Mark entered, try again!");
                }
            } while (curMark != 999);
        }
    }
}
