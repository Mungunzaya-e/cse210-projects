using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.\n");
        DateTime currentDateOnly = DateTime.Now.Date;
        string formattedDate = currentDateOnly.ToString("dd MMM yyyy");
        List<Activity> activities = new List<Activity>();

        RunningActivity running1 = new RunningActivity(currentDateOnly, "Running", 30, 15);
        activities.Add(running1);

        CyclingActivity cycling1 = new CyclingActivity(currentDateOnly, "Cycling", 40, 30);
        activities.Add(cycling1);

        SwimmingActivity swimming1 = new SwimmingActivity(currentDateOnly, "Swimming", 40, 40);
        activities.Add(swimming1);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}