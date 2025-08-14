using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, string name, int duration, int laps) : base(date, name, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / ((double)GetDuration() / 60);
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}