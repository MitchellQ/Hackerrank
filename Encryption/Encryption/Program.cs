using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        //Final Solution cleaned up and added comments

        /// <summary>
        /// Reads in a string from std in and then writes out the encrypted string
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) => Console.WriteLine(Encryption(Console.ReadLine()));


        /// <summary>
        /// Takes in the string and removes the whitespace
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string Encryption(string s)
        {
            string sw = Regex.Replace(s, @"\s+", "");

            string[,] matrix = GenMatrix(sw); 

            return Encode(matrix);            
        }

        /// <summary>
        /// Takes in the string and generates a 2d array of strings from each letter, The number of columns is 
        /// determined by the sqrt of the string length
        /// </summary>
        /// <param name="sw"></param>
        /// <returns>
        /// A 2d array of strings
        /// </returns>
        private static string[,] GenMatrix(string sw)
        {
            int swLength = sw.Length, rows = Convert.ToInt32(Math.Floor(Math.Sqrt(swLength))), cols = Convert.ToInt32(Math.Ceiling(Math.Sqrt(swLength))), c = -1, r = -1;
            if (rows * cols < swLength) rows++;
            string[,] matrix = new string[cols, rows];

            for (int i = 0; i < swLength; i++)
            {
                c = (c + 1) % cols;
                if (c == 0)
                    r++;

                matrix[c, r] = sw[i].ToString();
            }

            return matrix;
        }

        /// <summary>
        /// Takes in the 2d array of strings called matrix and returns the encrypted text string
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns>
        /// An encrypted string
        /// </returns>
        private static string Encode(string[,] matrix)
        {
            string encoded = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)                
                    encoded += matrix[i, j];
                
                encoded += " ";
            }

            return encoded;
        }
    }
}

//Original Solution
//private static string Encryption(string s)
//{
//    string sw = Regex.Replace(s, @"\s+", "");
//    int swLength = sw.Length;
//    int rows = Convert.ToInt32(Math.Floor(Math.Sqrt(swLength))), cols = Convert.ToInt32(Math.Ceiling(Math.Sqrt(swLength)));
//    if (rows * cols < swLength) rows++;

//    string[,] matrix = GenMatrix(sw, swLength, rows, cols);

//    return Encode(matrix);
//}

//private static string[,] GenMatrix(string sW, int swLength, int rows, int cols)
//{
//    string[,] matrix = new string[cols, rows];
//    int c = -1, r = -1;

//    for (int i = 0; i < swLength; i++)
//    {
//        c = (c + 1) % cols;
//        if (c == 0)
//            r++;

//        matrix[c, r] = sW[i].ToString();
//    }

//    return matrix;
//}

//private static string Encode(string[,] matrix)
//{
//    string encoded = "";

//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//            encoded += matrix[i, j];

//        encoded += " ";
//    }

//    return encoded;
//}
