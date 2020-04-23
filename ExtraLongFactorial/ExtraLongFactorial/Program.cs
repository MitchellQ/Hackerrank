using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExtraLongFactorial
{
    class Program
    {
        public static BigInteger ExtraLongFactorials(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * ExtraLongFactorials(n - 1);
        }

        static void Main(string[] args)
        {        
           //BigInteger x = ExtraLongFactorials(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(ExtraLongFactorials(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
