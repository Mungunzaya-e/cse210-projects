using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements: I added some message for the Quit option where it thanks the user and shows 
        // how many times the user tried each of the activities.

        Console.Clear();
        Console.WriteLine("This is the Mindfulness Project Menu: ");
        Console.WriteLine("\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit");
        Console.Write("Select a choice from the menu by typing in the number: ");
        string userChoice = Console.ReadLine();
        int choiceIndex = int.Parse(userChoice);

        int countBreathingActivity = 0;
        int countReflectingActivity = 0;
        int countListingActivity = 0;

        while (choiceIndex != 4)
        {
            if (choiceIndex == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();

                countBreathingActivity += 1;
            }

            else if (choiceIndex == 2)
            {
                Console.Clear();
                List<string> reflectPrompts = [
                    "Think of a time when you did something that stretched your abilities.",
                    "Think of a time when you stood up for someone.",
                    "Think of a time when you helped a friend in need.",
                    "Think of a time when you showed a mercy for someone.",
                    "Think of a time when you used your voice to protect yourself or others."
                ];

                List<string> reflectQuestions = [
                    "How did this experience impact you?",
                    "How did you get started?",
                    "What lesson have you learned?",
                    "Have this experience change the way you see yourself?",
                    "What is your favorite thing about this experience?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                ];

                ReflectingActivity reflection = new ReflectingActivity(reflectPrompts, reflectQuestions);
                reflection.Run();

                countReflectingActivity += 1;
            }

            else if (choiceIndex == 3)
            {
                Console.Clear();
                List<string> listPrompts = ["Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "What are the things you appreciate in yourself?",
                    "What are you grateful for?",
                    "What do you enjoy doing?"];

                ListingActivity listing = new ListingActivity(listPrompts);
                listing.Run();

                countListingActivity += 1;
            }

            Console.Clear();
            Console.WriteLine("This is the Mindfulness Project Menu: ");
            Console.WriteLine("\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit");
            Console.Write("Select a choice from the menu by typing in the number: ");
            userChoice = Console.ReadLine();
            choiceIndex = int.Parse(userChoice);
        }

        if (choiceIndex == 4)
        {
            Console.WriteLine("\nThank you for visiting the Mindfulness Program! \nHere are the numbers of times you've tried each of these activities:");
            Console.WriteLine($"\n  Breathing ACtivity: {countBreathingActivity}\n  Reflecting ACtivity: {countReflectingActivity}\n  Listing Activity: {countListingActivity}\n");
        }
    }
}