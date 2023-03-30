using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string");
        string sentence=Console.ReadLine();
        int count=0;
        foreach(char character in sentence)
        {
            count++;
        }
        Console.WriteLine($"the length of the string {count}");

    }
}
