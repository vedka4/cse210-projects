using System;

class Program
{
    static void Main(string[] args)
    {
      MatAssignment Rod = new MatAssignment("5-7","Fractions","Rodce", "5-7 , 8-9");
      string summaryF = Rod.GetSummary();
      string summary = Rod.GetHomeworkList();
      Console.WriteLine($"{summaryF} {summary}");

    
      WritingAssingment Rod2 = new WritingAssingment(" The Causes of World War II by", " Mary Waters", "European History");
      string done = Rod2.GetSummary();
      string doneF = Rod2.GetWritingInformation();
      Console.Write($"{done}  {doneF}");
    }

}
