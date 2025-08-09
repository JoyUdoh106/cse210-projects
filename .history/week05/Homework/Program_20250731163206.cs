using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MathAssignment mathAssignment = new MathAssignment("John Doe", "Trigolometry", "7.3", "1-10");

            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetHomeworkList());
        }
    }

}
