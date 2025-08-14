using System;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, string name, int duration, double distance) : base(date, name, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / ((double)GetDuration() / 60);
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }
}