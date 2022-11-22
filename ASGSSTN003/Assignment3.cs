using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASGSSTN003
{
    public class String_
    {
        public static int SpaceCount(string str)
        {
            int count = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    count++;
            }
            return count;
        }
        public static void Main()
        {
            string str2;
            Console.Write("\n\nFunction to count number of spaces in a string :\n");
            Console.Write("----------------------------------------------------\n");
            Console.Write("Please input a string : ");
            str2 = Console.ReadLine();
            Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", SpaceCount(str2));
            Console.ReadKey();
        }
    }
}
