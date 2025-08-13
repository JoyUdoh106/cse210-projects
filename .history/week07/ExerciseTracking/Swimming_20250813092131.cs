using System;

namespace ExerciseTracking 
{
    public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, double lengthInMinutes, int numberOfLaps) 
        : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }
    
    public override double GetDistance()
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        // Lap = 50 meters
        // Convert laps to miles
        return _numberOfLaps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        // We can call our own GetDistance method to avoid duplicating the calculation
        double distance = GetDistance();
        return (distance / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        // We can call our own GetDistance method here as well
        double distance = GetDistance();
        if (distance == 0) return 0; // Avoid division by zero
        return GetLengthInMinutes() / distance;
    }
}
}