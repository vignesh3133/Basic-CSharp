using System;
namespace Q9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num1=int.Parse(Console.ReadLine());
        int i=1;
        while(i<=num1)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
