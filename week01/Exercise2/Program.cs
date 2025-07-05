using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade Percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        string letterGrade = "";
        string sign = "";

        if (gradePercentage >= 90 && gradePercentage <= 100)
        {
            letterGrade = "A";
        }

        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            letterGrade = "B";
        }

        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            letterGrade = "C";
        }

        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            letterGrade = "D";
        }

        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}{sign}. ");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed! Well done. You did a great Job. Keep it up. ");
        }

        else
        {
            Console.WriteLine("You failed! Better luck next time. ");
        }

        int lastDigit = gradePercentage % 10;

        if (letterGrade != "F")
        {
            if (lastDigit >= 7 && letterGrade != "A") // A+ not allowed
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

    }
}