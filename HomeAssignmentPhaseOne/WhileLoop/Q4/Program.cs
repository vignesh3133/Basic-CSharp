using System;
namespace Q4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter balance 8 numbers:");
        int num1=2,num10=2,sum=0;
        float average;
        int num2=int.Parse(Console.ReadLine());
        int num3=int.Parse(Console.ReadLine());
        int num4=int.Parse(Console.ReadLine());
        int num5=int.Parse(Console.ReadLine());
        int num6=int.Parse(Console.ReadLine());
        int num7=int.Parse(Console.ReadLine());
        int num8=int.Parse(Console.ReadLine());
        int num9=int.Parse(Console.ReadLine());
        sum=num1+num2+num3+num4+num5+num6+num7+num8+num9+num10;
        average= (float)sum/10;
        Console.WriteLine(sum);
        Console.WriteLine(average);
    }    
}
