using System;
namespace Q10;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the count");
        int count=int.Parse(Console.ReadLine());
        int i=1,sum=0,result=0;
        while(i<=count)
        {
            Console.WriteLine(i);
            sum=i*i;
            result=result+sum;
            i++;

        }
        Console.WriteLine($"the sum series is {result}");
    }
}
