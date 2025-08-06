using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";
        _duration = 30;
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        Console.Clear();

        Console.WriteLine("Get Ready ...");
        ShowSpinner(3);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}