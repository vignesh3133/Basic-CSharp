using System;
namespace Q3;
class Program {
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        Console.WriteLine($"today={date.DayOfWeek}");
        Console.WriteLine($"day of the week 40 days after the current date {date.AddDays(40).DayOfWeek}");
        
    }
}
