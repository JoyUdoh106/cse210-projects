using System;

namespace Exercise 
{
    public abstract class Activity 
    {
          DateTime _date;
        private double _lengthInMinutes;

        public Activity(DateTime date, double lengthInMinutes)
        {
            _date = date;
            _lengthInMinutes = lengthInMinutes;
        }
    }
}