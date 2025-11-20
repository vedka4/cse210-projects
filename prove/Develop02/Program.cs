using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._firstName = "Leticia";
        p1._lastName = "Leon";
        p1._age = 60;

        Person p2 = new Person();
        p2._firstName = "Cesar";
        p2._lastName = "Rodriguez";
        p2._age = 64;

        List<Person> myPeople = new List<Person>();
        myPeople.Add(p1);
        myPeople.Add(p2);

        foreach (Person p  in myPeople)
        {
            Console.WriteLine($"This so far : {p._firstName} {p._lastName} {p._age}");

        }
    }
    
}