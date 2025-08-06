using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions)
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = prompts;
        _questions = questions;
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int choice = rnd.Next(_prompts.Count);

        return _prompts[choice];
    }

    public string GetRandomQuestion()
    {
        Random rndQuestion = new Random();
        int choice = rndQuestion.Next(_questions.Count);

        return _questions[choice];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }

    public void DisplayQuestion()
    {
        Console.Write($"---{GetRandomQuestion()}--- ");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get Ready ...");
        ShowSpinner(3);

        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        string userResponse = Console.ReadLine();

        Console.Write("\nNow ponder on each of the following questions as they are related to this experience.\nYou may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime futureTime = DateTime.Now.AddSeconds(_duration-10);

        while (DateTime.Now < futureTime)
        {
            Console.Write($"> {GetRandomQuestion()}  "); ;
            ShowSpinner(7);

            Console.WriteLine();
        }

        DisplayEndingMessage();
        
    }
}