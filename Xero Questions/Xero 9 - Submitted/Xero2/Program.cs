using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero2
{
    class Result
    {               
        public static double Calculate_profit(string revenue_and_cost_stats, List<string> exchange_rates)
        {
            string[] tokens = revenue_and_cost_stats.Split(',');
            double rev = double.Parse(tokens[1]), cost = double.Parse(tokens[3]), cRate = 0;
            string rCurrency = tokens[2], cCurrency = tokens[4], date = tokens[0].Substring(0, 9);

            //Inefficeint
            foreach (string s in exchange_rates)
                if (s.Contains(date))
                    cRate = double.Parse(s.Split(',')[1]);

            if (rCurrency == "AUD")
                rev = (rev * cRate);

            if (cCurrency == "AUD")
                cost = (cost * cRate);

            //Inelegant solution
            return double.Parse(string.Format("{0:0.00}", rev - cost));
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            string revenue_and_cost_stats = Console.ReadLine();

            int exchange_ratesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> exchange_rates = new List<string>();

            for (int i = 0; i < exchange_ratesCount; i++)
            {
                string exchange_ratesItem = Console.ReadLine();
                exchange_rates.Add(exchange_ratesItem);
            }

            double result = Result.Calculate_profit(revenue_and_cost_stats, exchange_rates);

            Console.WriteLine(result);
        }
    }
}
