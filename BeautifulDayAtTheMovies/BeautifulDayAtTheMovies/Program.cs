using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDayAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = BeautifulDays(i, j, k);

            Console.WriteLine(result);

        }

        static int BeautifulDays(int i, int j, int k)
        {
            int nBeautifulDays = 0;

            for(int l = i; l <= j; l++)
                if (IsBeautiful(l, k)) nBeautifulDays++;

            return nBeautifulDays;
        }

        static bool IsBeautiful(int day, int divisor)
        {
            int n = day, rev = 0, rem;

            while(n > 0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n /= 10;
            }           

            if ((day - rev) % divisor == 0) return true;

            return false;
        }
    }
}
