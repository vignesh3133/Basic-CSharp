using System;
namespace Q2;
class Program {
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        Console.WriteLine($"today={date}");
        Console.WriteLine($"After 40 days from this moment {date.AddDays(40).DayOfWeek}");
        
    }
}
