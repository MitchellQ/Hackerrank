using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            //Apples discard all that fall left (negative)
            //Orange discard all that fall right (positve)
            int applesHit = 0, orangesHit = 0;

            foreach (int apple in apples)
                if (apple > 0 && (a + apple >= s && a + apple <= t))
                    applesHit++;

            foreach (int orange in oranges)
                if (orange < 0 && (b - (orange * -1) >= s && b - (orange * -1) <= t))
                    orangesHit++;

            Console.WriteLine(string.Format("{0}\n{1}", applesHit, orangesHit));
        }
    }
}
