using System;
namespace Q4;
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
        Array.Sort(arr1);
        foreach(int a in arr1)
        {
            if(a==arr1[0])
            {
            Console.WriteLine($"the minimum element is {a} ");
            }
            
            else if(a==arr1[number-1])
            Console.Write($"the maximum element is {a} ");
            
        }
        
    }
}
