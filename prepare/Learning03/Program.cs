using System;

public  class Program
{
    static void Main(string[] args)
    {
         Fraction primera = new Fraction(1);
         Fraction segunda = new Fraction(5);
         Fraction tercera = new Fraction(3,4);

         Console.WriteLine($"{primera.GetTop()}/{primera.GetBottom()}");
         Console.WriteLine($"{segunda.GetTop()}/{segunda.GetBottom()}");
         Console.WriteLine($"{tercera.GetTop()}/{tercera.GetBottom()}");
    }
    
}