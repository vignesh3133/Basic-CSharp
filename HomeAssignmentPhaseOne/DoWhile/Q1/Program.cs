using System;
namespace Q1;
class Program{
    public static void Main(string[] args)
    {
        
        
        string opinion=string.Empty;
        do{
            Console.WriteLine("enter a number");
            int num=int.Parse(Console.ReadLine());
            if(num%2==1)
            {
                Console.WriteLine("result:given number is odd number");
            }
            else{
                Console.WriteLine("result:given number is even number");
            }
            Console.WriteLine("Do you want continue:yes or no");
            Console.WriteLine("input choice: ");
            opinion=Console.ReadLine().ToUpper();
        }while(opinion=="YES");


    }
}
