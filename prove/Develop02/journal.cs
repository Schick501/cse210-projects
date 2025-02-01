using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> journal = new List<Entry>();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filePath = "journal.json";

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            journal = JsonSerializer.Deserialize<List<Entry>>(json);
        }

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. View journal");
            Console.WriteLine("3. Save and exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                journal.Add(new Entry(DateTime.Now, prompt, response));
            }
            else if (choice == "2")
            {
                foreach (var entry in journal)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (choice == "3")
            {
                string json = JsonSerializer.Serialize(journal);
                File.WriteAllText(filePath, json);
                break;
            }
        }
    }
}