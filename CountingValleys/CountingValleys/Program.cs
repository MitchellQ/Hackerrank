
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countingValleys(8, "UDDDUDUU"));

            Console.ReadLine();
        }

        static int countingValleys(int n, string s)
        {
            int valleys = 0, altitude = 0;

            bool? inValley = null;

            for(int i = 0; i < s.Length; i++){

                switch (s[i]) {
                    case 'D':
                        altitude--;
                        break;
                    case 'U':
                        altitude++;
                        break;
                }//switch             

                if (altitude == 0 && inValley == true) valleys++;

                inValley = altitude < 0 ? true : false;
            }//for
            return valleys;
        }
    }
}
