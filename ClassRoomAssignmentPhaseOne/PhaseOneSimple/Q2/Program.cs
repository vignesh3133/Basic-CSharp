using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
        double basic=10000;
        double DA=10000*0.1;
        double HRA=10000*0.1;
        double tax=10000*0.05;
        double grossSalary=(basic+DA+HRA)-(tax);
        double annualSalary=grossSalary*12;
        Console.WriteLine($"His annual income is {annualSalary}");
    }
}
