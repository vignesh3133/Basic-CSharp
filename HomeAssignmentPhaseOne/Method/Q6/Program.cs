using System;
namespace Q6;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter first mark");
        int mark1=int.Parse(Console.ReadLine());
        Console.WriteLine("enter second mark");
        int mark2=int.Parse(Console.ReadLine());
        Console.WriteLine("enter third mark");
        int mark3=int.Parse(Console.ReadLine());
        Percentage(mark1,mark2,mark3);
    }

    public static void Percentage(int mark1,int mark2,int mark3)
    {
        int sum;
        sum=mark1+mark2+mark3;
        float percentage=(float)(sum*100)/300;
        Console.WriteLine($"mark1: {mark1} mark2: {mark2} mark3: {mark3}");
        Console.WriteLine($"the percentage is {percentage}");
    }
}