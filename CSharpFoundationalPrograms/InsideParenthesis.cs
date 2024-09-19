using System;

namespace CSharpFoundational
{
    internal class InsideParenthesis
    {
        public static void Main()
        {
            string message = "(What if) there are (more than) one (set of parentheses)?";
            const string openChar = "(";
            const string closeChar = ")";
            int openPos = 0;
            int closePos = 0;
            
            while(openPos != -1 || closePos != -1)
            {
                openPos = message.IndexOf(openChar);
                closePos = message.IndexOf(closeChar);
                
                if(openPos == -1 || closePos == -1)
                    continue;
                
                openPos += openChar.Length;
                int length = closePos - openPos;
                
                string messageSub = message.Substring(openPos, length);
                Console.WriteLine(messageSub);
                
                message = message.Substring(closePos + 1);
            }
        }
    }
}