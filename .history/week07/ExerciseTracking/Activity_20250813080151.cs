using System;

namespace Exercise 
{
    public abstract class Activity 
    {
         rivate DateTime _date;
        private double _lengthInMinutes;

        public Activity(DateTime date, double lengthInMinutes)
        {
            _date = date;
            _lengthInMinutes = lengthInMinutes;
        }
    }
}