class GoalTracker
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void AddGoal(Goal goal) => goals.Add(goal);

    public int RecordEvent(int index)
    {
        int earned = goals[index].RecordEvent();
        score += earned;
        return earned;
    }

    public void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    public int GetScore() => score;

    public void Save(string filename)
    {
        var data = new Dictionary<string, object>
        {
            {"Score", score},
            {"Goals", goals.ConvertAll(g => g.ToDict())}
        };
        File.WriteAllText(filename, JsonSerializer.Serialize(data));
    }

    public void Load(string filename)
    {
        var json = File.ReadAllText(filename);
        var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);

        score = data["Score"].GetInt32();

        goals = new List<Goal>();
        foreach (var goalElement in data["Goals"].EnumerateArray())
        {
            var goalDict = JsonSerializer.Deserialize<Dictionary<string, object>>(goalElement.GetRawText());
            goals.Add(Goal.FromDict(goalDict));
        }
    }
}