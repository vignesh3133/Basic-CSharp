using System;
namespace Q8;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter name of fisrt person:");
        string first= Console.ReadLine();
        Console.WriteLine("enter name of second person:");
        string second= Console.ReadLine();
        string value1=first.Substring(first.IndexOf(" ")+1);
        string value2=second.Substring(second.IndexOf(" ")+1);
        if(string.Compare(value1,value2)<0)
        {
            Console.WriteLine("Sorted alphabetically by last name");
            Console.WriteLine(first);
            Console.WriteLine(second);

        }
        else{
            Console.WriteLine("sorted alphabetically by last name");
            Console.WriteLine(second);
            Console.WriteLine(first);
        }

    }
}
