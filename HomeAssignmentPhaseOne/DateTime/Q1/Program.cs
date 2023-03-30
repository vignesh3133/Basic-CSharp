using System;
namespace Q1;
class program
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2016,8,16,3,57,32,11);
        Console.WriteLine($"year= {date.Year}");
        Console.WriteLine($"month= {date.Month}");
        Console.WriteLine($"day= {date.Day}");
        Console.WriteLine($"hour= {date.Hour}");
        Console.WriteLine($"minute= {date.Minute}");
        
        Console.WriteLine($"second= {date.Second}");
        Console.WriteLine($"millisecond= {date.Millisecond}");
    }
    
}