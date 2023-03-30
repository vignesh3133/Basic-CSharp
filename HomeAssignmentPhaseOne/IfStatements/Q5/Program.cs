using System;
namespace Q5{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a age: ");
            float age= float.Parse(Console.ReadLine());
            Console.WriteLine("enter the gender: ");
            char gender=char.Parse(Console.ReadLine());
            if(age>=16 && gender=='m')
            {
                Console.WriteLine("Mr.");
            }
            else if(age<16 && gender=='m')
            {
                Console.WriteLine("Master");
            }
            else if(age>=16 && gender=='f')
            {
                Console.WriteLine("Ms.");
            }
            else if(age<16 && gender=='f')
            {
                Console.WriteLine("Miss");
            }
        }
    }
}

