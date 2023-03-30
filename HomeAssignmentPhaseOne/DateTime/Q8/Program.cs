using System;
namespace Q8;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a date MM/dd/yyyy");
        DateTime date = DateTime.Parse(Console.ReadLine());
        
        Console.WriteLine($"date in words {date.ToLongDateString()}");
    }
}
