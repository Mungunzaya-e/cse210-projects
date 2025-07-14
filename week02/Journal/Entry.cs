using System;


public class Entry
{
    public string _date = "";
    public string _randomPrompt = "";
    public string _entryText = "";

    public Entry()
    {
    }

    public override string ToString()
    {
        return $"{_date} ~ {_randomPrompt} ~ {_entryText}";
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_randomPrompt}\n{_entryText}\n");
    }
}

