using System;
namespace Q1;
class Program{
    public static void Main(string[] args)
    {
        char option=char.Parse(Console.ReadLine());
        switch(option){
            case 'E':{
                Console.WriteLine("excellent");
                break;
            }
            case 'V':{
                Console.WriteLine("Very good");
                break;
            }
            case 'G':{
                Console.WriteLine("good");
                break;
            }
            case 'A':{
                Console.WriteLine("average");
                break;
            }
            case 'F':{
                Console.WriteLine("fail");
                break;
            }
        }
    }
}
