using System;

public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, string name, int duration, double speed) : base(date, name, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * ((double)GetDuration() / 60);
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}