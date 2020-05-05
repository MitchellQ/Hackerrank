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
            int count = 0;
            for(int i = 0; i < s.Length; i += 3)
            {
                if (s[i] != 'S') count++;
                if (s[i + 1] != 'O') count++;
                if (s[i + 2] != 'S') count++;
            }

            return count;
        }
        
        //Didn't work on some edge cases 
        //private static int MarsExploration(string s) => s.Length - ((s.Length - s.Replace("S", "").Length) + (s.Length - s.Replace("O", "").Length));


    }
}
