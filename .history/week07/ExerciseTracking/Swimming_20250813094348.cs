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
            return _numberOfLaps * 50.0 / 1000.0 * 0.62;
        }

        public override double GetSpeed()
        {
            double distance = GetDistance();
            return (distance / GetLengthInMinutes()) * 60;
        }

        public override double GetPace()
        
            double distance = GetDistance();
            if (distance == 0) return 0; // Avoid division by zero
            return GetLengthInMinutes() / distance;
        }
    }
}