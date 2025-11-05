using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name : ");
        string name = Console.ReadLine();
        Console.Write(name);
        Console.Write("What is your LastName : ");
        string LastName= Console.ReadLine();
        Console.Write($"Your Name is {LastName}, {name} {LastName}.");
    }
}