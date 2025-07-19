using System;
using System.Collections.Generic; 
using System.Linq;

namespace ScriptureMemorizer
{
    class Scripture
    {
        private Reference _reference; 
        private List<Word> _words;
        private Random _random; 

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            _random = new Random();

            string[] rawWords = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string rawWord in rawWords)
            {
                _words.Add(new Word(rawWord));
            }
        }

        public string GetDisplayText()
        {
            string displayText = _reference.GetDisplayText() + " ";

            foreach (Word word in _words)
            {
                displayText += word.GetDisplayText() + " ";
            }

            return displayText.Trim();
        }

        public void HideRandomWords(int count)
        {
            List<Word> unhiddenWords = _words.Where(word => !word.IsHidden()).ToList();

            if (unhiddenWords.Count == 0)
            {
                return;
            }

            int wordsToHide = Math.Min(count, unhiddenWords.Count);

            for (int i = 0; i < wordsToHide; i++)
            {
                int indexToHide = _random.Next(unhiddenWords.Count);
                unhiddenWords[indexToHide].Hide(); 
                unhiddenWords.RemoveAt(indexToHide);
            }
        }

        public bool HasUnhiddenWords()
        {
            return _words.Any(word => !word.IsHidden());
        }
    }
}