using System;
namespace Q9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter first string:");
        string str1= Console.ReadLine();
        Console.WriteLine("enter second string:");
        string str2= Console.ReadLine();
        string str;
        int result=string.CompareOrdinal(str1,str2);
        str=(result<0)?"less than" :(result>0)?"greater than" :"equal to";
        Console.WriteLine($"{str1} {str} {str2}");

    }
}
