using System;
using System.Reflection.PortableExecutable;


public class MatAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MatAssignment(string section,string problem, string studentName, string topic) : base(studentName,topic)
    {
        _textbookSection = section;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section : {_textbookSection }, Problems : {_problems}";
    }
}