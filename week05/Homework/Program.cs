using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.\n");

        Assignment assignment1 = new Assignment("Barty Crouch", "Magical Creatures");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Peter Smith", "Fractions", "2.3", "10-15");
        Console.WriteLine("\n" + assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList() + "\n");

        WritingAssignment assignment3 = new WritingAssignment("Amy Wright", "History of Magic", "The Secrets of the Four Founders");
        Console.WriteLine("\n" + assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo() + "\n");
    }
}