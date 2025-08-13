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
    }
}