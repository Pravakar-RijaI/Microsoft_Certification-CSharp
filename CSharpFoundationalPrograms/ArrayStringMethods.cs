using System;

namespace CSharpFoundational
{
    internal class ArrayStringMethods
    {
        public static void Main()
        {
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            string stringValue = new string(valueArray);
            Console.WriteLine(stringValue);
            
            string val = "sadf23";
            char[] valArr = val.ToCharArray();
            Array.Reverse(valArr);
            string strVal = string.Join(',',valArr);
            Console.WriteLine(strVal);
            
            string[] strValues = strVal.Split(',');
            foreach(string valuee in strValues)
            {
                Console.WriteLine(valuee);
            }
        }
    }
}