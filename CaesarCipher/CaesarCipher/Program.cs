
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

            Console.WriteLine(result);
        }

        private static string CaesarCipher(string s, int k)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            List<char> rotated = alphabet.Skip(k).ToList();
            rotated.AddRange(alphabet.Take(k));

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
