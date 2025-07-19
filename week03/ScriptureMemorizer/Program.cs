using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirement: I added a welcome message at the beginning and some choices of scriptures to choose from. 
        // So, the user can choose one of these scriptures by typing the index number before them and start memorizing the scripture. 

        Console.Clear();

        Console.WriteLine("Hello, Welcome to the Scripture Memorizer program!");
        Console.WriteLine("1. 1 Nephi 3:7\n2. 3 Nephi 11:10-11\n3. Ether 12:27\n4. Doctrine and Covenants 6:36\n5. Doctrine and Covenants 8:2-3");
        Console.Write("Please select a scripture to memorize (Enter the index): ");
        string choice = Console.ReadLine();
        int choiceNum = int.Parse(choice);

        if (choiceNum == 1)
        {
            Console.Clear();

            Scripture scriptureMemorize = new Scripture(new Reference("1 Nephi", 3, 7),
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

            Console.WriteLine(scriptureMemorize.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            while (userInput != "quit")
            {
                Console.Clear();

                scriptureMemorize.HideRandomWords(3);
                Console.WriteLine(scriptureMemorize.GetDisplayText());

                Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
                userInput = Console.ReadLine();
            }
        }

        else if (choiceNum == 2)
        {
            Console.Clear();

            Scripture scriptureMemorize = new Scripture(new Reference("# Nephi", 11, 10, 11),
            "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.");

            Console.WriteLine(scriptureMemorize.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            while (userInput != "quit")
            {
                Console.Clear();

                scriptureMemorize.HideRandomWords(3);
                Console.WriteLine(scriptureMemorize.GetDisplayText());

                Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
                userInput = Console.ReadLine();
            }
        }

        else if (choiceNum == 3)
        {
            Console.Clear();

            Scripture scriptureMemorize = new Scripture(new Reference("Ether", 12, 27),
            "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

            Console.WriteLine(scriptureMemorize.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            while (userInput != "quit")
            {
                Console.Clear();

                scriptureMemorize.HideRandomWords(3);
                Console.WriteLine(scriptureMemorize.GetDisplayText());

                Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
                userInput = Console.ReadLine();
            }
        }

        else if (choiceNum == 4)
        {
            Console.Clear();

            Scripture scriptureMemorize = new Scripture(new Reference("Doctrine and Covenants", 6, 36),
            "Look unto me in every thought; doubt not, fear not.");

            Console.WriteLine(scriptureMemorize.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            while (userInput != "quit")
            {
                Console.Clear();

                scriptureMemorize.HideRandomWords(3);
                Console.WriteLine(scriptureMemorize.GetDisplayText());

                Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
                userInput = Console.ReadLine();
            }
        }

        else if (choiceNum == 5)
        {
            Console.Clear();

            Scripture scriptureMemorize = new Scripture(new Reference("Doctrine and Covenants", 8, 2, 3),
            "Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.");

            Console.WriteLine(scriptureMemorize.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            while (userInput != "quit")
            {
                Console.Clear();

                scriptureMemorize.HideRandomWords(3);
                Console.WriteLine(scriptureMemorize.GetDisplayText());

                Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
                userInput = Console.ReadLine();
            }
        }

        
    }
}