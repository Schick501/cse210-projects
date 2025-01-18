using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = promptUserName();
        int userNumber = promptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResults(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program.");
    }

    static string promptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int promptUserNumber()
    {
        Console.Write("Please input your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"Hello, {name}. Your favorite number squared is {square}.");
    }
}