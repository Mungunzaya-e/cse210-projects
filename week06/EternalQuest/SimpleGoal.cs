using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }


    public override bool IsComplete() => _isComplete;

    public override int RecordEvent()
    {
        int intPoints = int.Parse(_points);

        if (!_isComplete)
        {
            _isComplete = true;
            return intPoints;
        }

        return 0;
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: ,{_shortName},{_description},{_points},{_isComplete}";
    }
}