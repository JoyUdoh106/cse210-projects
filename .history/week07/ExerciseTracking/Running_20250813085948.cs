using System;

namespace ExerciseTracking 
{
    public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, double lengthInMinutes, double distance) 
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return GetLengthInMinutes() / _distance;
    }
}
}