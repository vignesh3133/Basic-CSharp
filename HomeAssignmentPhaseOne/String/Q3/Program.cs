using System;
namespace Q3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string");
        string sentence=Console.ReadLine();
        char [] character=sentence.ToCharArray();
        foreach(char letter in character)
        {
            Console.Write($"{letter} ");
        }
        
        
    }
}
