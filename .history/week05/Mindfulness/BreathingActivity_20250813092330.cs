using System;
using System.Threading;

namespace Mindfulness {
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        protected override void PerformActivity()
        {
            Console.Clear();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("Breathe in... ");
                ShowCountDown(4);

                if (DateTime.Now >= endTime) break;

                Console.Write("Now breathe out... ");
                ShowCountDown(6);
                Console.WriteLine();
            }
        }
    }

}