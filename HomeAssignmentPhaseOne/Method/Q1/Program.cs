using System;
namespace Q1;
class Program{
    public static void Main(string[] args)
    {
        add();

    }
    public static void add()
    {
        
        Console.WriteLine("enter two numbers :");
        int num1=int.Parse(Console.ReadLine());
        int num2=int.Parse(Console.ReadLine());
        int sum;
        sum=num1+num2;
        Console.WriteLine($"the sum of two numbers {sum}");
    }
}
