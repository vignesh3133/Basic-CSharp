using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
        int i,sum=0;
        Console.WriteLine("enter the natural numbers");
        for(i=1;i<=10;i++)
        {
            Console.WriteLine(i);
            sum=sum+i;
        }
        Console.WriteLine("the sum is "+sum);
    }
}