
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = CaesarCipher(s, k);

            //Console.WriteLine(result);
        }

        /// <summary>
        /// Rotates the alphabet k number of times and the encrypts the string s before returning
        /// 
        /// A dictionary is used for o(1) lookup of encrypted characters
        /// </summary>
        /// <param name="s">The string to be encrypted</param>
        /// <param name="k">The number of characters to the left that the array will be rotated</param>
        /// <returns></returns>
        private static string CaesarCipher(string s, int k)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            //If k is greater than 26 this line is used to find the position of the encrypted 'a'
            int dividend = k % 26;
            List<char> rotated = alphabet.Skip(dividend).ToList();            
            rotated.AddRange(alphabet.Take(dividend));

            Dictionary<char, char> encrytedAlphabet = alphabet.Zip(rotated, (a, b) => new { a, b}).ToDictionary(item => item.a, item => item.b);

            char[] tmp = s.ToCharArray();
            for(int i = 0; i < tmp.Length; i++)
            {
                if (Char.IsLetter(tmp[i]))
                {
                    if (Char.IsUpper(tmp[i]))
                    {
                        tmp[i] = Char.ToUpper(encrytedAlphabet[Char.ToLower(tmp[i])]);
                    }
                    else
                    {
                        tmp[i] = encrytedAlphabet[tmp[i]];
                    }
                }
            }

            return new string(tmp);
        }
    }
}
