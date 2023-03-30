using System;
namespace Q8;
class Program{
    public static void Main(string[] args)
    {
        bool resultCondition,resultCondition1;
        Console.WriteLine("enter a value: ");
        int number=int.Parse(Console.ReadLine());
        resultCondition=(number==15)?true:false;
        resultCondition1=(number<=15)?true:false;
        Console.WriteLine(resultCondition);
        Console.WriteLine(resultCondition1);
    }
}
