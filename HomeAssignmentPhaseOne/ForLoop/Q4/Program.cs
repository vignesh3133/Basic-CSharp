using System;
namespace Q4;
class Q4{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
       
        int num1=int.Parse(Console.ReadLine());
        int sum=0;
        Console.WriteLine($"sum of {num1} is");
        while(num1>0)
        {
            sum+=num1;
            num1--;
        }
        Console.WriteLine($" {sum}");
    }
}
