using System;
namespace Q5;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num1=int.Parse(Console.ReadLine());
        int cube;
        for(int i=1;i<=num1;i++)
        {
            cube=i*i*i;
            Console.WriteLine($"Number is {i} and the cube of {i} is {cube}");
        }

        
    }

}

