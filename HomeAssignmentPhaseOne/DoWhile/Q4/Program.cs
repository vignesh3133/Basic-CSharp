using System;
namespace Q4;
class Program
{
public static void Main(string[] args)
{
    Console.WriteLine("enter a number");
    int num1=int.Parse(Console.ReadLine());
    int rem,sum=0;
    do{
        rem=num1%10;
        sum=sum+rem;
        num1=num1/10;
    }while(num1>0);
    Console.WriteLine($"sum of all digits are {sum}");
}
}

