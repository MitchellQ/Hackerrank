using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero1
{
    class Result
    {

        /*
         * Complete the 'calculate_coffee_stats' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING_ARRAY office_stats_list as parameter.
         */

        public static string Calculate_coffee_stats(List<string> office_stats_list)
        {
            SortedDictionary<String, double> yearlyCoffee = new SortedDictionary<string, double>();

            foreach(string s in office_stats_list)
            {
                string[] tokens = s.Split(',');
                string office = tokens[0];
                double nCups = int.Parse(tokens[2]);

                if (!yearlyCoffee.ContainsKey(office))
                {
                    yearlyCoffee.Add(office, nCups);
                }
                else
                {
                    yearlyCoffee[office] += nCups;
                }
            }

            string results = "";
            foreach (KeyValuePair<string, double> kvp in yearlyCoffee)
            {
                string office = kvp.Key;
                double nYear = Math.Floor(kvp.Value);
                double avg = Math.Floor(nYear / 12);

                results += string.Format("{0},{1},{2}\n", office, nYear, avg);
            }

            return results;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            

            int office_stats_listCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> office_stats_list = new List<string>();

            for (int i = 0; i < office_stats_listCount; i++)
            {
                string office_stats_listItem = Console.ReadLine();
                office_stats_list.Add(office_stats_listItem);
            }

            string result = Result.Calculate_coffee_stats(office_stats_list);

            Console.WriteLine(result);
        }
    }
}
