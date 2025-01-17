using System;

class Program
{
    static void Main(string[] args)
    {
        // this is a comment
        string adjective = GetAdjective();
        string noun = GetNoun();

        int number = Multiply(3, 4);

        Console.WriteLine($"I looked out the window and saw {number} {adjective} {noun}.");
    }

    static int Multiply(int number1, int number2)
    {
        int product = number1 * number2;
        
        return product;
    }



    static string GetAdjective()
    {
        List<string> words = new List<string>();
        words.Add("blue");
        words.Add("green");
        words.Add("yellow");
        words.Add("small");

        string adjactive = words[2];

        return adjactive;
    }

    static string GetNoun()
    {
        string noun = "bird";

        return noun;
    }
}