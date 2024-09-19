using System;

namespace CSharpFoundational
{
    internal class ReverseSentence
    {
        public static void Main()
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            char[] letters = pangram.ToCharArray();
            Array.Reverse(letters);
            string sentence = new string(letters);
            Console.WriteLine(sentence);
            
            string pangram1 = "The quick brown fox jumps over the lazy dog";
            string[] wordArr = pangram1.Split(' ');
            string finalSentence = "";
            
            for(int i = 0; i < wordArr.Length; i++)
            {
                char[] letterArr = wordArr[i].ToCharArray();
                Array.Reverse(letterArr);
                string temp = new string(letterArr);
                finalSentence += temp + " ";
            }
            Console.WriteLine(finalSentence);
            
        }
    }
}