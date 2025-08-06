using System;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _answers = new List<string>();

    public ListingActivity(List<string> prompts)
    {
        _prompts = prompts;
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by \nhaving you list as many things as you can in a certain area.";
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int choice = rnd.Next(_prompts.Count);

        return _prompts[choice];
    }

    public List<string> GetListFromUser()
    {
        Console.Write("> ");
        string userAnswer = Console.ReadLine();
        
        _answers.Add(userAnswer);

        return _answers;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get Ready ...");
        ShowSpinner(3);

        Console.WriteLine("\nList as many as you can to the following prompt:\n");
        Console.WriteLine($"---{GetRandomPrompt()}---\n");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime futureTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            GetListFromUser();
        }

        Console.WriteLine($"\nYou have listed {_answers.Count} items.");

        DisplayEndingMessage();
    }
}