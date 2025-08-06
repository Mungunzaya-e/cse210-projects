using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like your session to be? ");
        string second = Console.ReadLine();
        _duration = int.Parse(second);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);
        char[] spinner = { '|', '/', '-', '\\' };
        int index = 0;

        while (DateTime.Now < futureTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(400);
            Console.Write("\b \b");

            index = (index + 1) % spinner.Length;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
    }
}