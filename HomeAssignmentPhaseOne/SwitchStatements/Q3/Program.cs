using System;
namespace Q3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the month in number: ");
    
        int month=int.Parse(Console.ReadLine());
        switch(month){
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
            {
                Console.WriteLine("month have 31 days");
                break;
            }
            case 2:
            {
                Console.WriteLine("month have 28 days");
                break;
            }
            case 4:
            case 6:
            case 9:
            case 11:
            {
                Console.WriteLine("month have 30 days");
                break;
            }

            
        }
    }
}