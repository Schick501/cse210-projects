using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;


class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();

        p1.SetName("Jerry");
        p1.SetAge (23);

        p1.Display();

        string theName = p1.GetName();
        Console.WriteLine($"The person's name was: {theName}");
    }
}