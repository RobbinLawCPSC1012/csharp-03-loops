using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_loops_for_ClassAve
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt and read number of students
            Console.Write("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());

            // For Each student, prompt and read in their mark
            // Calculate a running total.
            double sumOfMarks = 0;
            double avgMark;
            double curMark;
            for (int i = 1; i <= numStudents; i++)
            {
                Console.Write($"Enter mark for student #{i}: ");
                curMark = double.Parse(Console.ReadLine());
                sumOfMarks += curMark;
            }

            // Calculate average mark
            avgMark = sumOfMarks / numStudents;
            // Display average mark
            Console.WriteLine($"Average Mark: {avgMark:n2}");
        }
    }
}
