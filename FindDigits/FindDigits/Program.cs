using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = FindDigits(n);

                Console.WriteLine(result);
            }
        }

        static int FindDigits(int n)
        {
            int nDivisor = 0;
            for(int i = 0; i < n.ToString().Length; i++)
            {
                if (n % Char.GetNumericValue(n.ToString()[i]) == 0)
                    nDivisor++;
            }
            return nDivisor;
        }
    }
}
