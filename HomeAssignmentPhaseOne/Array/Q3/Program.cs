using System;
namespace Q3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number=int.Parse(Console.ReadLine());
        int [] arr1=new int[number];
        int sum=0;
        for(int i=0;i<arr1.Length;i++)
        {
            arr1[i]=int.Parse(Console.ReadLine());
        }
        
        foreach(int a in arr1)
        {
            sum=sum+a;
            
        }
        Console.Write($"sum of all elements is {sum} ");
    }
}
