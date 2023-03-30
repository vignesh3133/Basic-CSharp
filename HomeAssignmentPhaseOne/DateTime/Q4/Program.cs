using System;
namespace Q4;
class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("enter date in MM/dd/yyyy format: ");
        DateTime date=DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"datetime ={date}");
        Console.WriteLine($"day of 15 days after {date.AddDays(15)}");
        Console.WriteLine($"day of 15 days before {date.AddDays(-15)}");
    }
}
