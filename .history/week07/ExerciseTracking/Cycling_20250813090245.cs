using System;

namespace ExerciseTracking
{
    public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, double lengthInMinutes, double speed) 
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }
    
    public override double GetDistance()
    {
        // Distance (miles) = speed (mph) * time (hours)
        // Time in hours = minutes / 60
        return _speed * (GetLengthInMinutes() / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = 60 / speed (mph)
        return 60.0 / _speed;
    }
}
}