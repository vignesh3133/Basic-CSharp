using System;
namespace Q1;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter a inr value: ");
        double inr=double.Parse(Console.ReadLine());
        double fixedUSD=1.22;
        double fixedEUR=1.27;
        double fixedCNY=8.79;
        double USD=inr/100*fixedUSD;
        double EUR=inr/100*fixedEUR;
        double CNY=inr/100*fixedCNY;
        Console.WriteLine($"{inr}rs = {USD} USD");
        Console.WriteLine($"{inr}rs = {EUR} EUR");
        Console.WriteLine($"{inr}rs = {CNY} CNY");

    }
}
