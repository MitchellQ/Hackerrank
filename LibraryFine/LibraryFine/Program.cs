
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFine
{
    class Program
    {
        static int LibraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            DateTime dueDate = new DateTime(y2, m2, d2), returnDate = new DateTime(y1,m1,d1);

            if(returnDate < dueDate)
                return 0;
            

            if(dueDate.Year > returnDate.Year)
                return 10000;

            if(!(dueDate.Month == returnDate.Month))
            {
                return (500 * (returnDate.Month - dueDate.Month));
            }
            
            if(!(dueDate.Day == returnDate.Day))
            {
                return (15 * (returnDate.Day - dueDate.Day));
            }

            return 0;
        }

        static void Main(string[] args)
        {
            string[] d1M1Y1 = Console.ReadLine().Split(' ');

            int d1 = Convert.ToInt32(d1M1Y1[0]);

            int m1 = Convert.ToInt32(d1M1Y1[1]);

            int y1 = Convert.ToInt32(d1M1Y1[2]);

            string[] d2M2Y2 = Console.ReadLine().Split(' ');

            int d2 = Convert.ToInt32(d2M2Y2[0]);

            int m2 = Convert.ToInt32(d2M2Y2[1]);

            int y2 = Convert.ToInt32(d2M2Y2[2]);

            int result = LibraryFine(d1, m1, y1, d2, m2, y2);

            Console.WriteLine(result);
        }
    }
}
