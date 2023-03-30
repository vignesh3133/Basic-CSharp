using System;
namespace Q5;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a table");
        int table= int.Parse(Console.ReadLine());
        int i=1;
        Console.WriteLine("enter a number");
        int number=int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine($"{i}*{table}={i*table}");
            i++;
        }while(i<=number);
    }
}
