using System;

namespace CSharpFoundational
{
    internal class StringIndexOfMethods
    {
        public static void Main()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');
            string subString = message.Substring(openingPosition + 1,closingPosition - openingPosition - 1);

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);
            Console.WriteLine(subString);

            string message1 = "What is the value <span>between the tags</span>?";

            int openingPosition1 = message1.IndexOf("<span>");
            int closingPosition1 = message1.IndexOf("</span>");
            Console.WriteLine(openingPosition1 + "\n" + closingPosition1);
            openingPosition1 += 6;
            int length = closingPosition1 - openingPosition1;
            string insideSpan = message1.Substring(openingPosition1, length);
            Console.WriteLine(insideSpan);
            
            string message2 = "What is the value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";
            
            int openPos = message2.IndexOf(openSpan);
            int closePos = message2.IndexOf(closeSpan);
            
            openPos = openPos + openSpan.Length;
            int length2 = closePos - openPos;
            
            string spanInside = message2.Substring(openPos,length2);
            Console.WriteLine(spanInside);

        }
    }
}