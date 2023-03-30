using System;
namespace Q10;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter first date");
        DateTime firstDate=DateTime.Parse(Console.ReadLine());
        Console.WriteLine("enter second date");
        DateTime secondDate=DateTime.Parse(Console.ReadLine());
        TimeSpan difference=secondDate-firstDate;
        int days=difference.Days;
        Console.WriteLine($"The difference in the dates is {days} days");

    }
}
