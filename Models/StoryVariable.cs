using System.Collections.Generic;
using System;

namespace MadLibs.Models
{
    public static class StoryVariable
    {
        private static Dictionary<string, string> _storyWords = new Dictionary<String, String>() {};

        public static void AddStoryWord(string key, string value)
        {
            _storyWords.Add(key, value);
        }
        public static Dictionary<string, string> GetStoryWords()
        {
            return _storyWords;
        }
    }
}
