using System;
namespace Q7;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string:");
        string sentence=Console.ReadLine();
        Console.WriteLine("enter a search string");
        string searchstr=Console.ReadLine();
        Console.WriteLine("enter a substring to add");
        string substr=Console.ReadLine();
        int index=sentence.IndexOf(searchstr);
        substr=substr.Trim()+" ";
        sentence=sentence.Insert(index,substr);
        Console.WriteLine($"the modified string is:{sentence}");


    }
}
