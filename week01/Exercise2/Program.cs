using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter in your grade percentage: ");
        string inputGrade = Console.ReadLine();
        int numberGrade = int.Parse(inputGrade);

        string letterGrade = "x";
        string gradeSign = "";

        if (numberGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (numberGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (numberGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (numberGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // determine if the grade is + or -
        if (numberGrade < 95 && numberGrade > 60 && (numberGrade % 10) >= 7)
        {
            gradeSign = "+";
        }
        else if (numberGrade > 60 && (numberGrade % 10) < 3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }

        // print the grade
        Console.WriteLine($"Your letter grade is {letterGrade}{gradeSign}.");


        // Determine if they have passed or not
        if (numberGrade >= 70)
        {
            Console.WriteLine("Congratulations, you have PASSED!");
        }
        else
        {
            Console.WriteLine("Sorry, you should try again for next time...");
        }
    }
}