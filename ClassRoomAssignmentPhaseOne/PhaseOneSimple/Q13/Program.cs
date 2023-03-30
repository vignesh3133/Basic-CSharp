using System;
namespace Q13;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string:");
        string str= Console.ReadLine().ToLower();
        char [] arr1=str.ToCharArray();
        Array.Reverse(arr1);
        Console.WriteLine(arr1);
    }
}

