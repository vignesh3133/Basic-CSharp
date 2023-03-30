using System;
namespace Q3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the celsius:");
        int celsius=int.Parse(Console.ReadLine());
        Console.WriteLine("Kelvin="+(celsius+273.15));
        Console.WriteLine("Fahrenheit={0}",celsius*9/5+32);
    }
}
