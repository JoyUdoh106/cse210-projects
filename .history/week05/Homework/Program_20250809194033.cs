using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a base "Assignment" object
            Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(a1.GetSummary());

                
            MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        }
    }

}
