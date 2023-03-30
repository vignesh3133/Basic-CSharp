using System;
namespace Q4;
class Program{
    public static void Main(string[] args)
    {
        int MM;
        float inch;
        double mile;
        int foot;

        
        Console.WriteLine("length=");
        int meter=int.Parse(Console.ReadLine());
        int CM=meter*100;
        Console.WriteLine($"CM= {CM}");
        MM=CM*10;
        
        Console.WriteLine($"MM= {MM}");
        inch=(float)39.3*meter;
        Console.WriteLine($"Inch={inch}");
        foot=meter*12;
        Console.WriteLine($"foot= {foot}");
        mile=(double)0.0006213715277778*meter;
        Console.WriteLine($"mile= {mile}");


        
    }
}