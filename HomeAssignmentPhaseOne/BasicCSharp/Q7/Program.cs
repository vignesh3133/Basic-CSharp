using System;
namespace Q7;
class Program{
    public static void Main(string[] args)
    {
        int distance;
        Console.WriteLine("enter the speed value: ");
        int speed=int.Parse(Console.ReadLine());
        Console.WriteLine("enter the time value: ");
        int time=int.Parse(Console.ReadLine());
        distance= speed*time*5/18;
        Console.WriteLine($"distance travelled= {distance} meters");

    }
}

