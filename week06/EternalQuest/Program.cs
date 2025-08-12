using System;

class Program
{
    static void Main(string[] args)
    {
        //Exceeding Requirement: I have added a feature where it awards the user with badges when they earn certain amount of points.

        Console.WriteLine("Welcome to the Eternal Quest Program!!\n");

        GoalManager goalManager = new GoalManager();
        Console.WriteLine();
        goalManager.Start();
    }
}