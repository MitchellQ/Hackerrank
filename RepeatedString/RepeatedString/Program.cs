using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aba"; // Console.ReadLine();

            long n = 10; //Convert.ToInt64(Console.ReadLine());

            long result = s.Length == 1 && s[0] == 'a' ? n : RepeatedString(s, n);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static long RepeatedString(string s, long n)
        {
            long count;
            int occurences =  GetOccurences(s);

            if(s.Length % n == 0)
            {
                count = (n / s.Length) * occurences;
            }
            else
            {
                long r = n % s.Length;
                int rCount = 0;

                for(int i = 0; i < r; i++)
                {
                    if (s[i] == 'a') rCount++;
                }

                count = ((n / s.Length) * occurences) + rCount;
            }

            return count;
        }//RepeatedString

        /// <summary>
        /// Count occurences of 'a' in string s
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int GetOccurences(string s)
        {
            int occurences = 0;

            foreach(char c in s)
            {
                if (c == 'a') occurences++;
            }

            return occurences;
        }//GetOccurences
    }
}
