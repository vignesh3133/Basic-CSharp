using System;
namespace Q5;
class Program{
    public static void Main(string[] args)
    {
        Prime();
    }

    public static void Prime()
    {
        Console.WriteLine("enter a number: ");
        int number=int.Parse(Console.ReadLine());
        int i=2;
        while(i<number){
            if(number%i==0){
            Result();
            break;
            }
            else{
            Result1();
            break;
            }
            i++;
        }

    }

    public static void Result()
    {
        Console.WriteLine("It is not prime number:");
    }
    public static void Result1()
    {
        Console.WriteLine("It is a prime number");
    }
}
