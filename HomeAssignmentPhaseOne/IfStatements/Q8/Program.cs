using System;
namespace Q8;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number=int.Parse(Console.ReadLine());
        if(number>0){
            Console.WriteLine($"{number} is a positive number");
        }
        else{
            Console.WriteLine($"{number} is a negative number");
        }
    }
}