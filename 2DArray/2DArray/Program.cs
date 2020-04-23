using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];


            System.IO.StreamReader file = new System.IO.StreamReader(@"d:\My Stuff\Desktop\arr.txt");

            while (!file.EndOfStream)
            {
                for (int i = 0; i < 6; i++)
                {
                    arr[i] = Array.ConvertAll(file.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                }

                int result = HourglassSum(arr);

                Console.WriteLine(result);
            }//while

            Console.ReadLine();
        }

        private static int HourglassSum(int[][] arr)
        {
            List<int> sums = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    sums.Add(
                        arr[i][j] +
                        arr[i][j + 1] +
                        arr[i][j + 2] +

                        arr[i + 1][j + 1] +

                        arr[i + 2][j] +
                        arr[i + 2][j + 1] +
                        arr[i + 2][j + 2]
                        );
                }
            }

            sums.Sort();

            return sums[sums.Count - 1];
        }
    }
}
