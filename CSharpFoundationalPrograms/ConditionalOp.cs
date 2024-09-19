using System;

namespace CSharpFoundational

public class ConditonalOp 
{
    public static void Main(string[] args)
    {
        Random coin = new Random();
        
        for(int i = 0; i < 50; i++)
        {
            int flip = coin.Next(2);
            string flipResult = (flip == 0) ? "Heads" : "Tails";
            Console.WriteLine (flipResult);
        }
    }
}