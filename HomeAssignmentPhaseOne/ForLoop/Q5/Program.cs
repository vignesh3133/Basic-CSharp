
using System;
namespace Q5;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter  a number");
        int num1=int.Parse(Console.ReadLine());
        int sum=0,rem=0;
        while(num1>0)
        {
            rem=num1%10;
            sum=sum*10+rem;
            num1=num1/10;


        }
        Console.WriteLine("the reverse is");
        Console.WriteLine($"{sum}");

    }
}