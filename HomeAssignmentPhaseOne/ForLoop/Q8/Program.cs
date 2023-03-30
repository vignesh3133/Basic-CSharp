using System;
namespace Q8;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num3=int.Parse(Console.ReadLine());
        int num1=-1,num2=1,i=0,sum=0;
        //Console.WriteLine(num1);
        //Console.WriteLine(num2);
        while(i<num3)
        {
            Console.WriteLine(sum=num1+num2);
            num1=num2;
            num2=sum;
            i++;
        }


    }
}