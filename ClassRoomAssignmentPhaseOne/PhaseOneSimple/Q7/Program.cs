using System;
namespace Q7;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a base number");
        int baseNumber=int.Parse(Console.ReadLine());
        Console.WriteLine("enter a exponential number");
        int expNumber=int.Parse(Console.ReadLine());
        int result=1;
        while(expNumber!=0)
        {
            result*=baseNumber;
            expNumber--;
        }
        Console.WriteLine($"The answer is {result}");
    }
}
