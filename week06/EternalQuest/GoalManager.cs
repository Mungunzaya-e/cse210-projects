using System;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Events");
            Console.WriteLine("   6. Quit");

            Console.Write("Select an Option: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter a number from 1 to 6.");
                    break;
            }

            if (_score >= 1500)
            {
                Console.WriteLine("Congratulations, you earned a Gold Badge by earning 1500 points!");
            }

            else if (_score >= 1000)
            {
                Console.WriteLine("Congratulations, you earned a Silver Badge by earning 1000 points!");
            }

            else if (_score >= 500)
            {
                Console.WriteLine("Congratulations, you earned a Bronze Badge by earning 500 points!");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your total score is {_score}.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetType().Name} - {_goals[i].GetDetailsString()}");
        }
    }

    // === List Detailed Goal Status ===
    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: \n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal");
        Console.Write("Choose a goal type: ");
        string goalChoice = Console.ReadLine();
        int goalIndex = int.Parse(goalChoice);

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();


        Console.Write("What is the short description of this goal? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();


        Goal newGoal = null;

        switch (goalChoice)
        {
            case "1":
                newGoal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
                break;
            case "2":
                newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                break;
            case "3":
                Console.Write("Enter number of times to complete: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, targetCount, bonus, 0);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created!");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? (Enter number): ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice <= _goals.Count)
        {
            int pointsEarned = _goals[choice].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }
    
    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            string goalType = parts[0].Replace(":", "").Trim();


            Goal loadedGoal = goalType switch
            {
                "SimpleGoal" => new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4])),
                "EternalGoal" => new EternalGoal(parts[1], parts[2], parts[3]),
                "ChecklistGoal" => new ChecklistGoal(
                    parts[1], 
                    parts[2], 
                    parts[3], 
                    int.Parse(parts[5]), 
                    int.Parse(parts[4]),
                    int.Parse(parts[6]))
            };

            _goals.Add(loadedGoal);
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}