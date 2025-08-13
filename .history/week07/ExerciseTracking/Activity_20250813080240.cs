using System;

namespace Exercise 
{
    public abstract class Activity 
    {
        private DateTime _date;
        private double _lengthInMinutes;

        public Activity(DateTime date, double lengthInMinutes)
        {
            _date = date;
            _lengthInMinutes = lengthInMinutes;
        }

        protected double GetLengthInMinutes()
            {
                return _lengthInMinutes;
            }
            
            // Abstract methods to be overridden by derived classes
            public abstract double GetDistance(); // in miles
            public abstract double GetSpeed();    // in mph
            public abstract double GetPace();  
    }
}