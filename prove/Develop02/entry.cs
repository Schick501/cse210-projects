// filepath: /c:/Users/alexg/Desktop/winter 2025/CSE210/cse210-projects/prove/Develop02/entry.cs
using System;

public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(DateTime date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Prompt}\n{Response}\n";
    }
}