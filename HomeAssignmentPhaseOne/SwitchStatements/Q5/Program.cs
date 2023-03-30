using System;
namespace Q5;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter one letter");
        char alphabet=char.Parse(Console.ReadLine());

        switch(alphabet){
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            {
                Console.WriteLine("It is a vowel");
                break;
            } 
            default:
            {
                Console.WriteLine("It is a not vowel");
                break;
            }

        }
    }
}
