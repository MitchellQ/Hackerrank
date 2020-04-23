using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_MaxSum
{
    class Program
    {
        //5th and final solution
        static void MiniMaxSum(int[] arr) => Console.WriteLine("{0} {1}", arr.Take(4).Sum(v => (long)v), arr.Skip(1).Sum(v => (long)v));

        /*
            4th Solution
            long min = arr.Take(4).Sum(v => (long)v);
            long max = arr.Skip(1).Sum(v => (long)v);
            Console.WriteLine("{0} {1}", arr.Take(4).Sum(v => (long)v), arr.Skip(1).Sum(v => (long)v));


            Used editorial section to solve as the above wasnt working 1st solution
            long sum = 0, min = 1000000000, max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                long n = arr[i];
                sum += n;

                if (min > n)
                    min = n;

                if (max < n)
                    max = n;
            }


            2nd solution
            Array.Sort(arr);
            long sum = arr.Sum(v => (long)v), min = arr[0], max = arr[arr.Length - 1];
            Console.WriteLine("{0} {1}", sum - max, sum - min);

            3rd Solution
            long sum = arr.Sum(v => (long)v);
            Console.WriteLine("{0} {1}", sum - arr[arr.Length - 1], sum - arr[0]);
         */



        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Array.Sort(arr);
            MiniMaxSum(arr);
        }
    }
}
