using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
        int num=int.Parse(Console.ReadLine());
        switch(num%2){
            case 0:{
                Console.WriteLine(num+" is an odd");
                break;
            }
            case 1:{
                Console.WriteLine(num+" is a even");
                break;
            }
        }
    }
}