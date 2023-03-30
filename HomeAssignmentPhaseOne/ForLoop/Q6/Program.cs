using System;
namespace Q6;
class Q6{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num1=int.Parse(Console.ReadLine());
        int i=0,sum=0;
        while(i<num1)
        {
            Console.WriteLine("Enter a number to sum: ");
            int num2=int.Parse(Console.ReadLine());
            sum=sum+num2;
            i++;
        }
        
        Console.WriteLine(sum);
    }
}