using System;

namespace CSharpFoundational
{
    internal class Project1
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Number between 5 and 10: ");
            string input = " ";
            int number = 0;
            
            do
            {
                input = Console.ReadLine();
                if(int.TryParse(input, out number))
                    {
                       if(number <= 5 || number >= 10)
                                Console.WriteLine($"You entered {input}. Please enter a Number between 5 and 10: ");
                    }
                else
                {
                        Console.WriteLine("Sorry, You have entered invalid number. Please try again.");
                }
            }while(number <= 5 || number >= 10);
            
            Console.WriteLine($"Your input {number} was accepted.");
        }
    }
}