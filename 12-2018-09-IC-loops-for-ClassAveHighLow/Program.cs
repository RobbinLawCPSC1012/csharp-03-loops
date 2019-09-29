using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2018_09_IC_loops_for_ClassAveHighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents;
            double curMark;
            double minMark = 101;
            double maxMark = -1;
            double sumOfMarks = 0;
            double avgMark;

            // Grab our input
            Console.Write("Enter number of students: ");
            numStudents = int.Parse(Console.ReadLine());

            // Loop over each of our students
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter mark for student #{i + 1}: ");
                curMark = double.Parse(Console.ReadLine());

                // Is this the highest or lowest mark we've seen?
                if (curMark < minMark)
                {
                    minMark = curMark;
                }
                if (curMark > maxMark)
                {
                    maxMark = curMark;
                }

                // Add it to our totals
                sumOfMarks += curMark;
            }

            // Calculate the average
            avgMark = (double)sumOfMarks / numStudents;

            // Print our results
            Console.WriteLine($"\nAverage Mark: {avgMark}, Highest Mark: {maxMark}, Lowest Mark: {minMark}");
        }
    }
}
