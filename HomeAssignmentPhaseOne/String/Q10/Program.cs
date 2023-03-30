using System;
namespace Q10;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string:");
        string str= Console.ReadLine().ToUpper();
        char [] arr1=str.ToCharArray();
        Array.Reverse(arr1);
        Console.WriteLine(arr1);
    }
}
