using System;
using System.Security.Cryptography.X509Certificates;

public class Assignment
{
    
    protected string _studentName;
    private string _topic;
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
        
    }
    public string GetSummary()
    {
        return $" Name : {_studentName}  {_topic}";
    }

}

