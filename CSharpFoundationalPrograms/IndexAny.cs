using System;

namespace CSharpFoundational
{
    internal class IndexAny
    {
        public static void Main()
        {
        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
        char[] symbols = {'[','{','('};
        int openingPosition = 0;
        
        while(openingPosition != -1)
        {
            openingPosition = message.IndexOfAny(symbols);
            
            if(openingPosition == -1)
                continue;
                
            string openingChar = message.Substring(openingPosition,1);
            string matchingChar = "";
            
            switch(openingChar)
            {
                case "[":
                matchingChar = "]";
                break;
                
                case "{":
                matchingChar = "}";
                break;
                
                case "(":
                matchingChar = ")";
                break;
                
                default:
                matchingChar = "";
                break;
            }
            
            int closingPosition = message.IndexOf(matchingChar);
            openingPosition += openingChar.Length;
            
            int length = closingPosition - openingPosition;
            
            string insideParen = message.Substring(openingPosition,length);
            Console.WriteLine(insideParen);
            
            message = message.Substring(closingPosition + 1);
            
        }
        }
    }
}