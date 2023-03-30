using System;
namespace Q7;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a month");
        int month=int.Parse(Console.ReadLine());
        Console.WriteLine("enter a year");
        int year=int.Parse(Console.ReadLine());
        int days=DateTime.DaysInMonth(year,month);
        Console.WriteLine($"the number of days {days}");

    }
}

