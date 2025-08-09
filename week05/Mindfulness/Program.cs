using System;

namespace Mindfulness {
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program Menu:");
                Console.WriteLine("  1. Start Breathing Activity");
                Console.WriteLine("  2. Start Reflection Activity");
                Console.WriteLine("  3. Start Listing Activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();
                Activity activity = null;

                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        Console.WriteLine("\nThank you for using the Mindfulness Program!"); Activity.DisplayLog(); // Display the session log
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Thread.Sleep(2000);
                        continue; // Skip the rest of the loop and show the menu again
                }

                activity.Run();
            }

        }
    }
}