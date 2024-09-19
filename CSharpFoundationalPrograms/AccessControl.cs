using System;

namespace CSharpFoundational
{
    internal class Accessontrol
    {
        public static void Main()
        {
            string permission = "clerk";
            //string userPermission;
            int level = 500;
            //int userLevel;
            
            // Console.WriteLine("Enter Your Designation: ");
            // userPermission = Console.ReadLine();
            
            // Console.WriteLine("Enter Your Level: ");
            // userLevel = Convert.ToInt32(Console.ReadLine());
            
            if(permission.Trim().ToLower().Contains("admin") && level > 55)
                    Console.WriteLine("Welcome, Super Admin User.");
            else if(permission.Trim().ToLower().Contains("admin") && level <= 55)
                Console.WriteLine("Welcome, Admin User");
            else if(permission.Trim().ToLower().Contains("manager") && level >= 20)
                Console.WriteLine("Contact an  admin for access.");
            else if(permission.Trim().ToLower().Contains("manager") && level < 20)
                Console.WriteLine("You do not have sufficent privileges");
                else if(!permission.Trim().ToLower().Contains("admin") && !permission.Trim().ToLower().Contains("manager") )
                Console.WriteLine("You do not have sufficent privileges");
        }
    }
}