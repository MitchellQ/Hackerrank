using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = MarsExploration(s);

            Console.WriteLine(result);
        }

        private static int MarsExploration(string s)
        {
        }

        //private static int MarsExploration(string s) => s.Length - ((s.Length - s.Replace("S", "").Length) + (s.Length - s.Replace("O", "").Length));


    }
}
