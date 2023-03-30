using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
        int i=0,sum=0;
        int n=int.Parse(Console.ReadLine());
        while(i<n){
            int a=int.Parse(Console.ReadLine());
            sum=sum+a;
            i++;
        }
        Console.WriteLine(sum);
    }
}
