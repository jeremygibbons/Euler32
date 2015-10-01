using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler32
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> results = new HashSet<int>();
            for(int n = 2; n < 50000; n++)
            {
                for(int m = 2; m <= Math.Sqrt(n); m++)
                {
                    if(n % m == 0)
                    {
                        int p = n / m;
                        if(is9PalindromicTriplet(n, m, p))
                        {
                            results.Add(n);
                            Console.WriteLine(n + " = " + m + " * " + p);
                        }
                    }
                }
            }
            Console.WriteLine(results.Sum());
            Console.ReadLine();
        }

        static bool is9PalindromicTriplet(int a, int b, int c)
        {
            string s = "" + a + b + c;
            char[] charr = s.ToCharArray();
            Array.Sort(charr);
            string sorted = new string(charr);
            return sorted == "123456789";
        }
    }
}
