using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class BinarySearch
    {
        int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);

                if (res == 0)
                    return m;

                if (res > 0)
                    l = m + 1;

                else
                    r = m - 1;
            }

            return -1;
        }

        public void Binary()
        {
            String[] arr = { "Luv", "Atul", "Rohit", "Deepak" };
            String x = "Atuls";
            int result = binarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Word not found");
            else
                Console.WriteLine("Word found at "
                                + "index " + result);
        }
    }
}

