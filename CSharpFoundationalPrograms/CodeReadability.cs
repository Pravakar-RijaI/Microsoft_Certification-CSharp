using System;

namespace CSharpFoundation
{
	internal class CodeReadability
	{
		public static void Main()
		{
		  //  Program to count number of 'O' in a sentence and reverse the sentence
		    
			int countO = 0;			
	
			string sentence = "The quick brown fox jumps over the lazy dog.";

			char[] sentenceLetters = sentence.ToCharArray();

			string reversedSentence;
			
			Array.Reverse(sentenceLetters);

			reversedSentence = new String(sentenceLetters);

			foreach (char letter in sentenceLetters)
			{
				if (letter == 'o' || letter == 'O')
				{
					countO++;
				}
			}
		
			Console.WriteLine($"Reversed Sentence: {reversedSentence}");
			Console.WriteLine($"'o' appears {countO} times in the sentence.");
		}
	}
}
