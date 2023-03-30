using System;
namespace Q3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the question:");
        string question=Console.ReadLine();
        string answer="YES";
        do
        {
        Console.WriteLine("select a.int b.continue c.break d.exit");
        char option=char.Parse(Console.ReadLine());
        switch(option)
        {
            case 'a':
            {
                Console.WriteLine("Incorrect! Try again");
                break;
            }
            case 'b':
            {
                Console.WriteLine("Incorrect! Try again");
                break;
            }
            case 'c':
            {
                Console.WriteLine("Correct");
                answer="NO";
                break;
            }
            case 'd':
            {
                answer="NO";
                break;
            }
        }
        }while(answer=="YES");
    }
}
