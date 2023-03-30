using System;
namespace Q12;
class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a date in MM/dd/yyyy format: ");
        DateTime date=DateTime.Parse(Console.ReadLine());
        
        Console.WriteLine($"the day in that specified date: {date.DayOfWeek}");
        
    }
}
