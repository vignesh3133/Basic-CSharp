using System;
namespace Q4;
class Program{
    public static void Main(string[] args)
    {
        Swap();
    }

    public static void Swap()
    {
        Console.WriteLine("enter two numbers: ");
        int num1=int.Parse(Console.ReadLine());
        int num2=int.Parse(Console.ReadLine());
        Console.WriteLine($"Before swap numbers are {num1} and {num2}");
        int temp;
        temp=num1;
        num1=num2;
        num2=temp;
        Console.WriteLine($"After swap numbers are {num1} and {num2}");
    }
}
