using System;
namespace Q5;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter two digit value");
        int sum=0,rem=0;
        int number=int.Parse(Console.ReadLine());
        while(number>0)
        {
            rem=number%10;
            sum=sum+rem;
            number=number/10;
        }
        Console.WriteLine($"sum is {sum}");

    }
}
