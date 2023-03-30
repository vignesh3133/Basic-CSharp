using System;
namespace Q7;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num1 = int.Parse(Console.ReadLine());
        /*
        int i = 1;
        while (i < num1)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even number ");
            }
            i++;
        }
        i=1;
        while (i < num1)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine($"{i} is odd number ");
            }
            i++;
        }*/
        int i = 2;
        
        while (i < num1)
        {

            if (i % num1 == 0)
            {
            
                //Console.WriteLine("It is not prime number:");
                break;
            }
            else{
            Console.WriteLine($"{i} It is prime number:");
        }


            i++;
        }
        
        
    }
}
