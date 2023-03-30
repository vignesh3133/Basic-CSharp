using System;
namespace Q5;
class Program {
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        Console.WriteLine($"Future year:{date.AddYears(1)} is later than {date}");
        Console.WriteLine($"Previous year:{date.AddYears(-1)} is earlier than {date}");
    }
}
