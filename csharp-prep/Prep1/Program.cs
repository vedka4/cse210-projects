using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)

    {
        Console.Write("What is your first name : ");
        string name = Console.ReadLine();
        Console.Write("What is your Last name : ");
        string LastName = Console.ReadLine();
        Console.WriteLine($"Your name is : {LastName} {name}");

        Console.Write("What is your grade percentage : ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 85)
        {
            letter = "B+";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 75)
        {
            letter = "C+";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        {
            Console.WriteLine($"Your grade letter is : {letter}");
        }
        if (number >= 70)
        {
            Console.WriteLine("Congratulation you passed the course");
        }
        else
        {
            Console.WriteLine("Keep working hard, you will do it");
        }



    }
    

    
}


