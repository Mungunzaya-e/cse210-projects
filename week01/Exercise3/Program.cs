using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int numberGuess = int.Parse(guess);
        int guessCount = 1;
        string keepPlaying = "yes";

        while (keepPlaying == "yes" && numberGuess != magicNumber)
        {
            if (numberGuess > magicNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                numberGuess = int.Parse(guess);
            }
            else if (numberGuess < magicNumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                numberGuess = int.Parse(guess);
            }

            guessCount++;

        }

        if (numberGuess == magicNumber)
        {
            Console.WriteLine("That is correct!");
        }

        Console.WriteLine($"You guessed it in {guessCount} tries.");
        Console.Write("Wanna play again? ");
        keepPlaying = Console.ReadLine();

        while (keepPlaying == "yes")
        {
            randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 100);

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            numberGuess = int.Parse(guess);
            guessCount = 1;
            keepPlaying = "yes";

            while (numberGuess != magicNumber)
            {
                if (numberGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    guess = Console.ReadLine();
                    numberGuess = int.Parse(guess);
                }
                else if (numberGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guess = Console.ReadLine();
                    numberGuess = int.Parse(guess);
                }

                guessCount++;

            }

            if (numberGuess == magicNumber)
            {
                Console.WriteLine("That is correct!");
            }

            Console.WriteLine($"You guessed it in {guessCount} tries.");
            Console.Write("Wanna play again? ");
            keepPlaying = Console.ReadLine();
        }
    }
}