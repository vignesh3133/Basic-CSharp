using System;
namespace Q6;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string:");
        string sentence=Console.ReadLine().ToUpper();
        
        int count=0,count1=0;
        for(int i=0;i<sentence.Length;i++)
        
        {
            
            if(sentence[i]=='A' || sentence[i]=='E' || sentence[i]=='I' || sentence[i]=='O' || sentence[i]=='U' )
            {
                count++;
            }
            else if(sentence[i]>='A' && sentence[i]<='Z')
            {
                count1++;
            }
        }
        Console.WriteLine(count);
        Console.WriteLine(count1);

    }
}

