class SimpleGoal : Goal
{
    private bool Completed;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        Completed = false;
    }

    public override int RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => Completed;

    public override string GetStatus() => $"[{(Completed ? "X" : " ")}] {Name}";

    public override Dictionary<string, object> ToDict() => new Dictionary<string, object>
    {
        {"Type", "SimpleGoal"},
        {"Name", Name},
        {"Points", Points},
        {"Completed", Completed}
    };

    public static SimpleGoal FromDict(Dictionary<string, object> data)
    {
        var goal = new SimpleGoal(data["Name"].ToString(), Convert.ToInt32(data["Points"]));
        goal.Completed = Convert.ToBoolean(data["Completed"]);
        return goal;
    }
}

class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent() => Points;

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[~] {Name} (eternal)";

    public override Dictionary<string, object> ToDict() => new Dictionary<string, object>
    {
        {"Type", "EternalGoal"},
        {"Name", Name},
        {"Points", Points}
    };

    public static EternalGoal FromDict(Dictionary<string, object> data)
    {
        return new EternalGoal(data["Name"].ToString(), Convert.ToInt32(data["Points"]));
    }
}

class ChecklistGoal : Goal
{
    private int Target;
    private int Bonus;
    private int Count;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {
        Target = target;
        Bonus = bonus;
        Count = 0;
    }

    public override int RecordEvent()
    {
        if (Count < Target)
        {
            Count++;
            return Points + (Count == Target ? Bonus : 0);
        }
        return 0;
    }

    public override bool IsComplete() => Count >= Target;

    public override string GetStatus() => $"[{(IsComplete() ? "X" : " ")}] {Name} (Completed {Count}/{Target})";

    public override Dictionary<string, object> ToDict() => new Dictionary<string, object>
    {
        {"Type", "ChecklistGoal"},
        {"Name", Name},
        {"Points", Points},
        {"Target", Target},
        {"Bonus", Bonus},
        {"Count", Count}
    };

    public static ChecklistGoal FromDict(Dictionary<string, object> data)
    {
        var goal = new ChecklistGoal(data["Name"].ToString(), Convert.ToInt32(data["Points"]), Convert.ToInt32(data["Target"]), Convert.ToInt32(data["Bonus"]));
        goal.Count = Convert.ToInt32(data["Count"]);
        return goal;
    }
}