using System;
namespace Q3;
class Program{
    public static void Main(string[] args)
    {
        Add();
    }

    public static void Add()
    {
        Console.WriteLine("enter number of elements");
        int num=int.Parse(Console.ReadLine());
        int [] arr1=new int[num];
        int sum=0;
        for(int i=0;i<arr1.Length;i++)
        {
            arr1[i]=int.Parse(Console.ReadLine());
            sum=sum+arr1[i];
        }
        Console.WriteLine($"The sum of the elements of the array is {sum}");



    }
}