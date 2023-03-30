using System;
namespace Q3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter first number: ");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number: ");
        int num2=int.Parse(Console.ReadLine());
        Console.WriteLine("input your choice: ");
        int option=int.Parse(Console.ReadLine());
        int add,sub,mul,div;
        
        switch(option)
        {
            case 1:
            {
                add=num1+num2;
                Console.WriteLine(add);
                break;
            }
            case 2:
            {
                sub=num1-num2;
                Console.WriteLine(sub);
                break;

            }
            case 3:
            {
                mul=num1*num2;
                Console.WriteLine(mul);
                break;
            }
            case 4:
            {
                div=num1/num2;
                Console.WriteLine(div);
                break;
            }
            case 5:
            {
            
                break;
            }
        }

    }
}