using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class PrimeNumberRange
    {
        public static void PrimeNumber()
        {
            int num, i, ctr, StartNum, LastNum;

            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.WriteLine("\n");


            Console.Write("Input starting number of range: ");
            StartNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            LastNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", StartNum, LastNum);

            for (num = StartNum; num <= LastNum; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num);
                }


            }

            Console.Write("\n");

        }
        public static bool IsPrime(int num)
        {
            int ctr = 0;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && num != 1)
                return true;

            else
                return false;
        }

    }
}
