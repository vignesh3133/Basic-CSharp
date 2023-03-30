using System;
namespace Q9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num=int.Parse(Console.ReadLine());
        int i,j;
        for(i=1;i<=num;i++)
        {
            for(j=1;j<=i;j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}