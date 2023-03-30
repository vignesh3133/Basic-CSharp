using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("enter your name:");
        string name=Console.ReadLine();
        Console.WriteLine("Welcome "+name);
        Console.WriteLine("Do you want to continue?");
        string a=Console.ReadLine().ToUpper();
        while(a=="YES"){
            Console.WriteLine("enter your name:");
            name=Console.ReadLine();
            Console.WriteLine("Welcome "+name);
            Console.WriteLine("Do you want to continue?");
            a=Console.ReadLine().ToUpper();
        }


    }
}
