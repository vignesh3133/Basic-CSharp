using System;
namespace Q7;
class Program{
    public static void Main(string[] args)
    {
        Calculate();
    }

    public static void Calculate()
    {
        Console.WriteLine("enter a number");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("enter a number");
        int num2=int.Parse(Console.ReadLine());
        Console.WriteLine($" addition is {num1+num2}");
        Console.WriteLine($" subtraction is {num1-num2}");
        Console.WriteLine($" Multiplication is {num1*num2}");
        Console.WriteLine($" division is {num1/num2}");

    }
}
