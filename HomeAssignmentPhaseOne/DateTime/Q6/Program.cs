using System;
namespace Q6;
class Program{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Today;
        Console.WriteLine("enter a date(MM/dd/yyy)");
        DateTime userDate=DateTime.Parse(Console.ReadLine());
        int result=DateTime.Compare(userDate,date);
        if(result<0)
        {
            Console.WriteLine($"{userDate} is in the past");
        }
        else if(result>0)
        {
            Console.WriteLine($"{userDate} is in the future");
        }
        else if(result==0)
        {
            Console.WriteLine($"{userDate} is as the current date");
        }
    }
}

