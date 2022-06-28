using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class PrimePalindromecs
    {
        public static bool isPalindrome(int n)
        {

            int rev = 0;
            for (int i = n; i > 0; i /= 10)
            {
                rev = rev * 10 + i % 10;
            }

            return (n == rev) ? true : false;
        }

        
        public static void countPal(int min,
                                    int max)
        {

            for (int i = min; i <= max; i++)
            {
                if (PrimeNumberRange.IsPrime(i) && isPalindrome(i))
                {
                    Console.WriteLine(i);
                }

                



            }


        }
    }
}
