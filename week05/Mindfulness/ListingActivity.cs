using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private PromptGenerator _promptGenerator;
        private int _itemCount;

        public ListingActivity() 
            : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            var prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
            _promptGenerator = new PromptGenerator(prompts);
        }

        protected override void PerformActivity()
        {
            _itemCount = 0;
            Console.Clear();
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"--- {_promptGenerator.GetRandomPrompt()} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                Console.ReadLine(); // Read the user's item
                _itemCount++;
            }
            
            Console.WriteLine($"You listed {_itemCount} items!");
        }
    }
}