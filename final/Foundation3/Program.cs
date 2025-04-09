class Program
{
    static void Main()
    {
        var tracker = new GoalTracker();

        while (true)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Choose Goal Type: 1) Simple 2) Eternal 3) Checklist");
                string gtype = Console.ReadLine();
                Console.Write("Goal Name: ");
                string name = Console.ReadLine();
                Console.Write("Points per completion: ");
                int points = int.Parse(Console.ReadLine());

                if (gtype == "1")
                    tracker.AddGoal(new SimpleGoal(name, points));
                else if (gtype == "2")
                    tracker.AddGoal(new EternalGoal(name, points));
                else if (gtype == "3")
                {
                    Console.Write("Times to complete: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    tracker.AddGoal(new ChecklistGoal(name, points, target, bonus));
                }
            }
            else if (choice == "2")
            {
                tracker.ListGoals();
            }
            else if (choice == "3")
            {
                tracker.ListGoals();
                Console.Write("Which goal? ");
                int index = int.Parse(Console.ReadLine()) - 1;
                int earned = tracker.RecordEvent(index);
                Console.WriteLine($"You earned {earned} points!");
            }
            else if (choice == "4")
            {
                Console.WriteLine($"Current Score: {tracker.GetScore()} points");
            }
            else if (choice == "5")
            {
                Console.Write("Filename to save: ");
                string filename = Console.ReadLine();
                tracker.Save(filename);
                Console.WriteLine("Goals saved.");
            }
            else if (choice == "6")
            {
                Console.Write("Filename to load: ");
                string filename = Console.ReadLine();
                tracker.Load(filename);
                Console.WriteLine("Goals loaded.");
            }
            else if (choice == "7")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}Console.Write("Which goal? ");
try
{
    if (int.TryParse(Console.ReadLine(), out int index))
    {
        index -= 1; // Adjust for zero-based indexing
        int earned = tracker.RecordEvent(index);
        Console.WriteLine($"You earned {earned} points!");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

if (choice == "4")
{
    Console.WriteLine($"Current Score: {tracker.GetScore()} points");
}
else if (choice == "5")
{
    Console.Write("Filename to save: ");
    string filename = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(filename))
    {
        try
        {
            tracker.Save(filename);
            Console.WriteLine("Goals saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("Filename cannot be empty.");
    }
}
else if (choice == "6")
{
    Console.Write("Filename to load: ");
    string filename = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(filename))
    {
        try
        {
            tracker.Load(filename);
            Console.WriteLine("Goals loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("Filename cannot be empty.");
    }
}
else if (choice == "7")
{
    Console.WriteLine("Goodbye!");
    break;
}