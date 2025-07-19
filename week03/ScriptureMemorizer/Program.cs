using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Reference reference1 = new Reference("John", 3, 16);
            string text1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            Scripture scripture1 = new Scripture(reference1, text1);

            Reference reference2 = new Reference("Proverbs", 3, 5, 6);
            string text2 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            Scripture scripture2 = new Scripture(reference2, text2);

            Scripture currentScripture = scripture1;

            string userInput = "";

            while (currentScripture.HasUnhiddenWords() && userInput.ToLower() != "quit")
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText()); 

                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                Console.Write("> ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() != "quit")
                {
                    currentScripture.HideRandomWords(3);
                }
            }

            Console.Clear(); 
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nProgram ended. Thank you for using the Scripture Memorizer!");
        }
    }
}