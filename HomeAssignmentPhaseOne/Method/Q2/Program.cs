using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
       
        count();
    }

    public static void count()
    {
        Console.WriteLine("enter a string");
        string str=Console.ReadLine();
        string [] arr1=str.Split(" ");
        Console.WriteLine($"the number of spaces {arr1.Length-1}");
    }
}
