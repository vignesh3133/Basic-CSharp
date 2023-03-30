using System;
namespace Q6;
class Program{
    public static void Main(string[] args){
        int total,taxAmount;
        Console.WriteLine("enter the price amount: ");
        int price= int.Parse(Console.ReadLine());
        taxAmount=(price*18)/100;
        total=price+taxAmount;
        Console.WriteLine("Total= "+total);
    }
}
        


