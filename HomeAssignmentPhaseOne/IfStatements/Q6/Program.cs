using System;
namespace Q6;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a temperature");
        int temp=int.Parse(Console.ReadLine());
        if(temp<0){
            Console.WriteLine("Freezing Weather");
        }
        else if(temp>=0 && temp<=10){
            Console.WriteLine("Very cold Weather");
        }
        else if(temp>10 && temp<=20){
            Console.WriteLine("cold Weather");
        }
        else if(temp>20 && temp<=30){
            Console.WriteLine("Normal in temperature");
        }
        else if(temp>30 && temp<=40){
            Console.WriteLine("Its hot");
        }
        else{
            Console.WriteLine("Its very hot");
        }

    }
}