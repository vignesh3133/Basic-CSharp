using System;
namespace Q2;
class Program{

    public static void Main(string[] args)
    {
        int i=0;
        int number=0,sum=0;
        Console.WriteLine("enter a count");
        int count=int.Parse(Console.ReadLine());
        do
        {
            
            Console.WriteLine($"enter the {i}th number");
            number=int.Parse(Console.ReadLine());
            if(number>=0)
            {
            sum=sum+number;
            }
            i++;
        }while(i<count);
        Console.WriteLine(sum);
}}

        
            


