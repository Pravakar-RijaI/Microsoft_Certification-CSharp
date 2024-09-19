
// Quantity: 5000
// Output: <h2>Widgets &reg;</h2><span>5000</span>


using System;

namespace CSharpFoundational
{
    internal class StringMethodChallenge
    {
        public static void Main()
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";
            
            const string openingChar1 = "<span>";
            const string closingChar1 = "</span>";
            
            int openingPosition1 = input.IndexOf(openingChar1);
            int closingPosition1 = input.IndexOf(closingChar1);
            
            openingPosition1 += openingChar1.Length;
            int length1 = closingPosition1 - openingPosition1;
            
            quantity = input.Substring(openingPosition1, length1);
            
            const string openingChar2 = "<div>";
            const string closingChar2 = "</div>";
            
            int openingPosition2 = input.IndexOf(openingChar2);
            string input1 = input.Remove(openingPosition2,openingChar2.Length);
            
            int closingPosition2 = input1.IndexOf(closingChar2);
            string input2 = input1.Remove(closingPosition2,closingChar2.Length);
            
            output = input2.Replace("trade","reg");

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");
        }
    }
}