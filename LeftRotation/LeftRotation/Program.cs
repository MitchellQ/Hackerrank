
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            //int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            Console.ReadLine();

        }

        static int[] rotLeft(int[] a, int d)
        {
            //Final Solution wwas given hints by the editorial section
            List<int> tmp = a.Skip(d).ToList();

            tmp.AddRange(a.Take(d));
           
            
            return tmp.ToArray();

            //Second Attempt also to slow
            //List<int> tmp = new List<int>();
            //for (int i = 0; i < d; i++)
            //{
            //    tmp = a.Skip(1).ToList();
            //    tmp.Add(a[0]);

            //    a = tmp.ToArray();
            //}

            //return a;

            //First Attempt to slow
            //int[] tmp = new int[a.Length];

            //for (int i = 0; i < d; i++)
            //{
            //    for (int j = 0; j < a.Length; j++)
            //        tmp[j] = (j == a.Length - 1 ? a[0] : a[j + 1]);

            //    a = tmp;
            //    tmp = new int[a.Length];
            //}

            //return a;
        }
    }
}
