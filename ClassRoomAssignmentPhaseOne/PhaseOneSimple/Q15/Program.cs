using System;
namespace Q15;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a name");
        string name=Console.ReadLine();
        PrintName(name);
        Print();

    }
    public static void PrintName(string name)
    {
        
        Console.WriteLine($"Welcome {name}");
    }
    public static void Print()
    {
        Console.WriteLine($"Have a nice day!");
    }
}