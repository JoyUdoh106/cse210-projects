using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class PromptGenerator
    {
        private readonly List<string> _sourcePrompts;
        private List<string> _availablePrompts;
        private readonly Random _random = new Random();

        public PromptGenerator(List<string> prompts)
        {
            _sourcePrompts = prompts;
            _availablePrompts = new List<string>(_sourcePrompts); // Create a copy to work with
        }

        public string GetRandomPrompt()
        {
            // If we've used all prompts, reset the list
            if (_availablePrompts.Count == 0)
            {
                _availablePrompts = new List<string>(_sourcePrompts);
            }

            int index = _random.Next(_availablePrompts.Count);
            string prompt = _availablePrompts[index];
            _availablePrompts.RemoveAt(index); // Remove the used prompt

            return prompt;
        }
    }
}