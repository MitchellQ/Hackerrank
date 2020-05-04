
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = Squares(a, b);

                Console.WriteLine(result);
            }
        }

        private static int Squares(int a, int b)
        {
            //initial too slow
            int count = 0;
            for (int i = a; i <= b; i++)
                if (Math.Pow(Math.Floor(Math.Sqrt(i)), 2) == i)
                    count++;

            return count;

            
            /*
             * From editorial section (don't really understand)
             * int count = 0;
                for (int i = 1; ; i++)
                {
                    if (i * i > b) break;
                    if (i * i <= b && i * i >= a) count++;
                }            

                return count;
             */
        }
    }
}
