using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = HackerrankInString(s);

               Console.WriteLine(result);
            }
        }

        private static string HackerrankInString(string input)
        {
            string toCompare = "hackerrank";

            SortedDictionary<char, int> toCompareCharCount = new SortedDictionary<char, int>();
            SortedDictionary<char, int> inputCharCount = new SortedDictionary<char, int>();
            foreach (char c in toCompare)
            {
                if (toCompareCharCount.ContainsKey(c))
                    toCompareCharCount[c]++;
                else
                    toCompareCharCount[c] = 1;
            }

            
            foreach (char c in input)
            {
                if (toCompare.Contains(c))
                {
                    if (inputCharCount.ContainsKey(c))
                        inputCharCount[c]++;
                    else
                        inputCharCount[c] = 1;
                }                
            }

            int count = 0;
            foreach (KeyValuePair<char, int> kvp in toCompareCharCount)
                if(inputCharCount.ContainsKey(kvp.Key) && inputCharCount[kvp.Key] >= kvp.Value) count++;
            

            return count == toCompareCharCount.Count() ? "YES" : "NO";
        }
    }
}
