using System;

namespace CSharpFoundational
{
    internal class SwitchStatements
    {
        public static void Main()
        {
            int employeeLevel = 100;
            string employeeName = "John Smith";
            string employeeTitle = "Non Employee";
            
            switch (employeeLevel)
            {
                case 100:
                case 200:
                        employeeTitle = "Senior Associate";
                        break;
                case 300:
                    employeeTitle = "Associate";
                    break;
                case 400:
                    employeeTitle = "Junior Associate";
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
               
            }
            
            Console.WriteLine($"{employeeName} : {employeeTitle}");
        }
    }
}