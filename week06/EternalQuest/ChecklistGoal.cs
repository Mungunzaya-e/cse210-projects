using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amount) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount;
    }

    public override bool IsComplete() => _amountCompleted >= _target;
    public override int RecordEvent()
    {
        _amountCompleted++;

        int basePoints = int.Parse(_points);
        int totalPoints = basePoints;

        if (_amountCompleted == _target)
        {
            totalPoints += _bonus;
        }

        return totalPoints;
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X]  {_shortName} ({_description}) -- currently completed: {_amountCompleted}/{_target}";
        }
        return $"[ ]  {_shortName} ({_description}) -- currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: ,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}