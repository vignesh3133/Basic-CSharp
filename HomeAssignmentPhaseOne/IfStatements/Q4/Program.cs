using System;
namespace Q1;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a speed value: ");
        float number=float.Parse(Console.ReadLine());
        if(number>0 && number<=10){
            Console.WriteLine("slow");
        }
        else if(number>10 && number<=50){
            Console.WriteLine("average"); 
        }
        else if(number>50 && number<=150){
            Console.WriteLine("fast"); 
        }
        else if(number>150 && number<=1000){
            Console.WriteLine("Ultra fast");
        }
        else if(number>1000){
            Console.WriteLine("extremely fast"); 
        }
        else{
            Console.WriteLine("Please enter a valid input");
        } 
        
    }
}

