using System;
namespace Q8;
class Program{
    public static void Main(string[] args)
    {
        int sum=0;
        for(int i=1;i<=99;i++)
        {
            if(i%2==1)
            {
                sum+=i*i;
            }
        }
        Console.WriteLine($"Sum of square of odd values {sum}");
    }
}