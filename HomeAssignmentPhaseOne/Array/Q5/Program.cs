using System;
namespace Q5;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number=int.Parse(Console.ReadLine());
        int [] arr1=new int[number];
        int [] odd=new int[number];
        int [] even=new int[number];
        int value1=0;
        int value2=0;

        for(int i=0;i<arr1.Length;i++)
        {
            arr1[i]=int.Parse(Console.ReadLine());
        }
        
        foreach(int element in arr1)
        {
            
            if((element%2)==1)
            {
                odd[value1++]= element;
                
            }
            else
            {
                even[value2++]=element;
                
            }
            
        }
        Console.WriteLine("odd elements are");
        for(int i=0;i<value1;i++)
        {
            Console.WriteLine($"{odd[i]} ");
        }
        Console.WriteLine("even elements are");
         for(int i=0;i<value2;i++)
        {
            Console.Write($"{even[i]} ");
        }
    }
}
