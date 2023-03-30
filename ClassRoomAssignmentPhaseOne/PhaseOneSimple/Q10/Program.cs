using System;
namespace Q10;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num1=int.Parse(Console.ReadLine());
        int i,j;
        for(i=1;i<=num1;i++)
        {
            for(j=1;j<=i;j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}