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
            
        public abstract double GetDistance(); 
        public abstract double GetSpeed(); 
        public abstract double GetPace();

        public virtual string GetSummary() 
        {
            string activityType = GetType().Name;
            double distance = GetDistance();\
            double speed = GetSpeed();
            double pace = GetPace();
 
            return $"{_date:dd MMM yyyy} {activityType} ({_lengthInMinutes} min) - " + $"Distance: {distance:F2} miles, Speed: {speed:F1}"
        } 
    }
}