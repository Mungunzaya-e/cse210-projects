using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string inputNumber = Console.ReadLine();
        int userNumber = int.Parse(inputNumber);
        numbers.Add(userNumber);

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            inputNumber = Console.ReadLine();
            userNumber = int.Parse(inputNumber);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (userNumber == 0)
        {
            float total = numbers.Sum(x => Convert.ToInt32(x));
            Console.WriteLine($"The total is: {total}");

            float average = total / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int largest = 1;
            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }
            Console.WriteLine($"The largest is: {largest}");
        }
        
    }
}