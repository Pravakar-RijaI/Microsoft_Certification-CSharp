using System;

namespace CSharpFoundational
{
    internal class Project3
    {
        public static void Main()
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

            string sentence = String.Join(".",myStrings);
            
            string[] individualSentences = sentence.Split('.');
            
            for(int i = 0; i < individualSentences.Length; i++)
            {
                individualSentences[i] = individualSentences[i].TrimStart();
                Console.WriteLine(individualSentences[i]);
            }

            
        
        }
    }
}