using System;

namespace CSharpFoundational
{
    internal class DisplayEmail
    {
        public static void Main()
        {
            string[,] corporate = 
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external = 
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < corporate.GetLength(0); i++) 
            {
                Console.WriteLine(displayInternal(firstName: corporate[i,0],lastName: corporate[i,1]));
            }

            for (int i = 0; i < external.GetLength(0); i++) 
            {
                Console.WriteLine(displayExternal(firstName: external[i,0],lastName: external[i,1],externalDomain));
            }
        }
        
        public static string displayInternal(string firstName, string lastName, string company = "contoso.com")
        {
            firstName = firstName.ToLower().Substring(0,2);
            lastName = lastName.ToLower();
            return $"{firstName}{lastName}@{company}";
        }
        
        public static string displayExternal(string firstName, string lastName, string company)
        {
            firstName = firstName.ToLower().Substring(0,2);
            lastName = lastName.ToLower();
            return $"{firstName}{lastName}@{company}";
        }
    }
}