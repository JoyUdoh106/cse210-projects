using System;
using System.Collections.Generic;

namespace Mindfulness
{
   public class ReflectionActivity : Activity
    {
        private PromptGenerator _promptGenerator;
        private PromptGenerator _questionGenerator;

        public ReflectionActivity() 
            : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            var prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            var questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
            
            _promptGenerator = new PromptGenerator(prompts);
            _questionGenerator = new PromptGenerator(questions);
        }

        protected override void PerformActivity()
        {
            Console.Clear();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {_promptGenerator.GetRandomPrompt()} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            
            Console.Clear();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write($"> {_questionGenerator.GetRandomPrompt()} ");
                ShowSpinner(10); // Give user 10 seconds to ponder
            }
        }
    }
}