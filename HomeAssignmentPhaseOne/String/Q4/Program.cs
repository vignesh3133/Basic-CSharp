using System;
namespace Q4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string");
        string sentence=Console.ReadLine();
        string [] word=sentence.Split(" ");
        Console.WriteLine(word.Length);
    }
}