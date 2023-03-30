using System;
namespace Q14;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string:");
        string sentence=Console.ReadLine().ToUpper();
        
        int count=0;
        bool flag=true;
        for(int i=0;i<sentence.Length;i++)
        
        {
            
            if(sentence[i]=='A' || sentence[i]=='E' || sentence[i]=='I' || sentence[i]=='O' || sentence[i]=='U' )
            {
                flag=false;
                count++;
            }
            
        }
        if(flag)
        {
            Console.WriteLine("there is no vowels");
        }
        Console.WriteLine(count);
        

    }
}

