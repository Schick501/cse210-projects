using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

abstract class Goal
{
    protected string Name;
    protected int Points;

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();

    public abstract Dictionary<string, object> ToDict();
    public static Goal FromDict(Dictionary<string, object> data)
    {
        string type = data["Type"].ToString();
        switch (type)
        {
            case "SimpleGoal": return SimpleGoal.FromDict(data);
            case "EternalGoal": return EternalGoal.FromDict(data);
            case "ChecklistGoal": return ChecklistGoal.FromDict(data);
            default: throw new Exception("Unknown goal type");
        }
    }
}