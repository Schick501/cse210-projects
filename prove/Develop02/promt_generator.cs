// filepath: /c:/Users/alexg/Desktop/winter 2025/CSE210/cse210-projects/prove/Develop02/prompt_generator.cs
using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class PromptGenerator
    {
        private List<string> prompts = new List<string>
        {
            "What are you grateful for today?",
            "What was the highlight of your day?",
            "What did you learn today?",
            "How did you feel today?",
            "What are your goals for tomorrow?"
        };

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}