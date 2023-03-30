using System;
namespace Q3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num1=int.Parse(Console.ReadLine());
        int multipleTable=5;
        Console.WriteLine("the multiples of 5 are");
        while(multipleTable<=num1)
        
        {
            Console.WriteLine($"{multipleTable}");
            multipleTable+=5;

        }
    }
}