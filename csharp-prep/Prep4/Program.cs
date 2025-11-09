using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
class Program

{
    static void Main(string[] args)
    {
        List<int> myFirstList = new List<int>();
        int total = 0;
        int aveg = 0;
        int attempts = 0;
        Console.Write("Please Enter Number : ");
        string numbers = Console.ReadLine();
        int numbersUser = int.Parse(numbers);
        while (numbersUser != 0)
        {
            myFirstList.Add(numbersUser);
            total = total + numbersUser;
            attempts++;
            Console.Write("Please Enter Number : ");
            numbers = Console.ReadLine();
            numbersUser = int.Parse(numbers);
            if (numbersUser > )
        }
        Console.WriteLine("The sum is :" + " " + total);
        aveg = (total / attempts);
        Console.WriteLine("The Average is : "+" " + aveg);
        
    }
}