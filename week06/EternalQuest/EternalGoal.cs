using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: ,{_shortName},{_description},{_points}";
    }
}