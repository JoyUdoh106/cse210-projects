using System;

namespace ExerciseTracing 
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new List<Activity>();

            activities.Add(new Running(new DateTime(2024, 07, 22), 30, 3.0)); // 30 mins, 3.0 miles
            activities.Add(new Cycling(new DateTime(2024, 07, 23), 60, 12.0)); // 60 mins, 12.0 mph
            activities.Add(new Swimming(new DateTime(2024, 07, 24), 45, 60));   // 45 mins, 60 laps

            Console.WriteLine("Exercise Tracking Summary:");
            Console.WriteLine("--------------------------");

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
            
            Console.WriteLine("--------------------------");
        }
    }
}
