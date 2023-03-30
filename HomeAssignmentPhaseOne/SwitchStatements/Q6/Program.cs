using System;
namespace Q6;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter first number");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number");
        int num2=int.Parse(Console.ReadLine());
        switch(num1>num2)
        {
            case true:{
                Console.WriteLine($"{num1} is a maximum number");
                break;
            }
            case false:{
                Console.WriteLine($"{num2} is a maximum number");
                break;
            }
        }
    } 
}