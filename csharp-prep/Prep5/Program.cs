using System;


 class Program
{
    static void DisplayWelcom()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string AskUserName()
    {
        Console.WriteLine("Please enter your UserName");
        string userN = Console.ReadLine();
        return userN;

    }
    static int favoriteNum()
    {
        Console.WriteLine("Please enter your favorite number");
        string resp = Console.ReadLine();
        int numberResp = int.Parse(resp);
        return numberResp;
    }
    static void Main(string[] args)
    {
        DisplayWelcom();
        AskUserName();
        favoriteNum();
    }
}
 