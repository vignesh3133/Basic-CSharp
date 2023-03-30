using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number=int.Parse(Console.ReadLine());
        int [] arr1=new int[number];
        for(int i=0;i<arr1.Length;i++)
        {
            arr1[i]=int.Parse(Console.ReadLine());
        }
        Array.Reverse(arr1);
        foreach(int a in arr1)
        {
            Console.Write($"{a} ");
        }
    }
}
