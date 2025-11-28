using System;
using System.Reflection.PortableExecutable;


public class WritingAssingment : Assignment
{
    private string _title;

    public WritingAssingment(string title,  string studentName , string topic) : base(studentName,topic)
    {
        _title = title;
    }

    public string  GetWritingInformation()
    {
        return $"  {_title}  {_studentName}";
    }

}