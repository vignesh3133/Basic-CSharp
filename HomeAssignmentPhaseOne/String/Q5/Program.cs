using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a first string");
        string firstString=Console.ReadLine();
        Console.WriteLine("enter a first string");
        string SecondString=Console.ReadLine();
        if(firstString==SecondString)
        {
            Console.WriteLine("The length of both strings is equal and also both strings are equal.");
        }
        else
        {
            Console.WriteLine("Either length or both strings are not equal");
        }



    }
}
