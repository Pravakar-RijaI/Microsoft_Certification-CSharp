using System;

namespace CSharpFoundational
{
    internal class ValidIp
    {
        public static void Main()
        {
            Console.WriteLine("Enter IpV4 Addresss: ");
            string ipAddress = Console.ReadLine();
            bool isValid = isIpValid(ipAddress);
            
            if(isValid)
                Console.WriteLine($"{ipAddress} is Valid.");
            else
                Console.WriteLine($"{ipAddress} is not Valid.");
        }
        
        public static bool isIpValid(string ipAddress)
        {
            string[] ipOctet = ipAddress.Split('.',StringSplitOptions.RemoveEmptyEntries);
            
            int number;
            
            if(ipOctet.Length != 4)
                return false;
            
            foreach(string octet in ipOctet)
            {
                if(octet[0] == '0' && octet.Length != 1)
                    return false;
                if(!(int.TryParse(octet,out number)))
                    return false;
                if(number > 255 || number < 0)
                    return false;
            }
            return true;
        }
            
    }
}