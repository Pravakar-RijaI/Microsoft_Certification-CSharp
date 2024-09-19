using System;

namespace CSharpFoundational
{
    internal class Project3
    {
        public static void Main()
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            for(int i = 0; i < myStrings.Length; i ++)
            {
                string myString = myStrings[i];
                int periodLocation = myString.IndexOf(".");
                string mySentence;
                
                while(periodLocation != -1)
                {
                    mySentence = myString.Remove(periodLocation);
                    
                    myString = myString.Substring(periodLocation + 1);
                    
                    myString = myString.TrimStart();
                
                    periodLocation = myString.IndexOf(".");
                    
                    Console.WriteLine(mySentence);
                }
                mySentence = myString.TrimStart();
                Console.WriteLine(mySentence);
            }
        }
    }
}