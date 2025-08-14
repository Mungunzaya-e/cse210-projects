using System;

public abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;
    private string _name;

    public Activity(DateTime date, string name, int duration)
    {
        _date = date;
        _durationMinutes = duration;
        _name = name;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _durationMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_durationMinutes} mins) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    } 
}