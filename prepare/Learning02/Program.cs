using System;

public class Program
{
    static void Main(string[] args)
    {

       Job job1 = new Job();

       job1._company = "VedkaSolution";
       job1._jobTitle = "Developer";
       job1._startYear = 2020;
       job1._endYear = 2023;

       Job job2 = new Job();

       job2._company = "VedkaNetworking";
       job2._jobTitle = "Engineer";
       job2._startYear = 2020;
       job2._endYear = 2023;

       Resume resume = new Resume();

        resume._name = "Cesar";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
   
    }
}