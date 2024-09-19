using System;


namespace CSharpFoundational
{
    internal class Project2
    {
        public static void Main()
        {
            Console.WriteLine("Enter Your Role (Administrator|Manager|User): ");
            string role = " ";
            while(!role.Trim().ToLower().Contains("administrator") && !role.Trim().ToLower().Contains("manager") && !role.Trim().ToLower().Contains("user"))
            {
                role = Console.ReadLine();
                
                if(!role.Trim().ToLower().Contains("administrator") && !role.Trim().ToLower().Contains("manager") && !role.Trim().ToLower().Contains("user"))
                    Console.WriteLine($"The role name that you entered, {role} is not valid. Enter your role name (Administrator, Manager, or User):");
            }
            
            Console.WriteLine($"Your Input Value: {role} is accepted.");
        }
    }
}