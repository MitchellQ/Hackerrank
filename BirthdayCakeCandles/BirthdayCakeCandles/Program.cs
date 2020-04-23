using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        //solution one
        //static int BirthdayCakeCandles(int[] ar) => ar.Where(x => x == ar.Max()).Count();

        //solution 2
        //static int BirthdayCakeCandles(int[] ar)
        //{
        //    int max = ar.Max();

        //    Dictionary<int, int> b = ar
        //        .GroupBy(item => item)
        //        .ToDictionary(item => item.Key, item => item.Count());
        //    return b[max];
        //}

        static int BirthdayCakeCandles(int[] ar)
        {
            Dictionary<int, int> b = ar
                .GroupBy(item => item)
                .ToDictionary(item => item.Key, item => item.Count());
            return b[ar.Max()];
        }

        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = BirthdayCakeCandles(ar);

        }
    }
}
