using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        private static Dictionary<string, int> _activityLog = new Dictionary<string, int>();

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void DisplayStartingMessage() {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(5);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(5);
        }

        protected void ShowSpinner(int seconds)
        {
            List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            int i = 0;

            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");

                i++;
                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }
            Console.WriteLine();
        }

        protected void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }

        protected abstract void PerformActivity();

        public static void DisplayLog()
        {
            Console.WriteLine("\n--- Session Activity Log ---");
            if (_activityLog.Count == 0)
            {
                Console.WriteLine("No activities were completed in this session.");
            }
            else
            {
                foreach (var entry in _activityLog)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value} time(s)");
                }
            }
            Console.WriteLine("--------------------------");
        }

        public void Run()
        {
            DisplayStartingMessage();
            PerformActivity();
            DisplayEndingMessage();

            if (!_activityLog.ContainsKey(_name))
            {
                _activityLog[_name] = 0;
            }

            _activityLog[_name]++;
        }
    }
}