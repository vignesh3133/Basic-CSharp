﻿using System;
namespace Q2;
class Program{
    public static void Main(string[] args)
    {
        int num=int.Parse(Console.ReadLine());
        if(num==0){
            Console.WriteLine("Zero");
        }
        else if(num==1){
            Console.WriteLine("One");
        }else if(num==2){
            Console.WriteLine("Two");
        }
        else if(num==3){
            Console.WriteLine("Three");
        }
        else if(num==4){
            Console.WriteLine("Four");
        }
        else if(num==5){
            Console.WriteLine("Five");
        }
        else if(num==6){
            Console.WriteLine("Six");
        }
        else if(num==7){
            Console.WriteLine("seven");
        }
        else if(num==8){
            Console.WriteLine("eight");
        }
        else if(num==9){
            Console.WriteLine("nine");
        }
        else{
            Console.WriteLine("Number too big");
        }
    }
}
