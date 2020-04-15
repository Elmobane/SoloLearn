using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloLearn
{
    class PigLatin
    {
        public static string ToPigLatin(string input)
        {
            
            string results = "";
            string[] words = input.ToLower().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length == 1)
                {
                    results += $"{word}ay ";
                }
                else
                {
                    char firstLetter = word[0];
                    results += $"{word.Substring(1)}{firstLetter}ay ";
                }
            }

            return results;
        }
    }
}
