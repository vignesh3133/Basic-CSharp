using System;
namespace Q9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("the leap years between 1994 and 2023");
        for(int i=1994;i<=2023;i++)
        {
            if(DateTime.IsLeapYear(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}