using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Anagram
    {
        static int NO_OF_CHARS = 256;

        
        public static bool areAnagram(string str1,
                               string str2)
        {

           
            if (str1.Length != str2.Length)
                return false;


            Array.Sort(str1.ToCharArray());
            Array.Sort(str2.ToCharArray());
            string a = str1.ToString();
            string b = str2.ToString();
            if (a != b)
            {

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

