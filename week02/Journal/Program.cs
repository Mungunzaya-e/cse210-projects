using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
            // Functional Requirements
            // This program must contain the following features:

            // Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
            // Display the journal - Iterate through all entries in the journal and display them to the screen.
            // Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
            // Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
            // Provide a menu that allows the user choose these options
            // Your list of prompts must contain at least five different prompts.

        // EXCEEDING REQUIREMENTS: Added another option to the menu to count the characters of the entries.

        PromptGenerator prompt = new PromptGenerator();
        DateTime theCurrentTime = DateTime.Now;
        
        Journal journal = new Journal();

        int choiceNumber = 0;

        while (choiceNumber != 6)
        {

            Console.WriteLine("Welcome to the Journal App! \nSelect one of the following choices: ");
            Console.WriteLine("\t1. Write a new entry \n\t2. Display the entries \n\t3. Save the journal to a file \n\t4. Load the journal from a file \n\t5. View character count \n\t6. Quit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            choiceNumber = int.Parse(choice);

            if (choiceNumber == 1)
            {

                prompt._prompts = ["What happened today?",
                    "What was the most interesting thing I saw or heard today?",
                    "What am I grateful for today?",
                    "What did I learn today?",
                    "How does my body feel today?",
                    "How am I feeling today?",
                    "What am I nervous or anxious about today?",
                ];

                Entry entry = new Entry();
                entry._date = theCurrentTime.ToShortDateString();
                entry._randomPrompt = prompt._getPrompt();
                Console.Write(entry._randomPrompt + "\n>> ");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }

            else if (choiceNumber == 2)
            {
                journal.DisplayAll();
            }

            else if (choiceNumber == 3)
            {
                journal.SaveToFile();
            }

            else if (choiceNumber == 4)
            {
                journal.LoadFromFile();
            }

            else if (choiceNumber == 5)
            {
                journal.GetTotalCharacterCount();
                int total = journal.GetTotalCharacterCount();
                Console.WriteLine(total);
            }
        }

    }
}