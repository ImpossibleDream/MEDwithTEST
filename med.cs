using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED
{
    public class getMED
    {
        static void Main(string[] args)
        {
            Console.Write("source string: ");
            string source = Console.ReadLine();
            //Console.WriteLine();

            Console.Write("target string: ");
            string target = Console.ReadLine();
            //Console.WriteLine();


            Console.WriteLine("Minimum Edit Distance: " + MED(source, target));
            //Console.Write();
            Console.ReadLine();
        }
        public static int MED(string source, string target)
        {
            int sSize = source.Length;
            int tSize = target.Length;

            if (sSize == 0)
            {
                return tSize;
            }
            if (tSize == 0)
            {
                return sSize;
            }
            int[,] matrix = new int[tSize + 1, sSize + 1];
            for (int i = 0; i <= sSize; i++)
            {
                matrix[0, i] = i;
            }
            for (int j = 1; j <= tSize; j++)
            {
                matrix[j, 0] = j;
            }
            for (int i = 0; i < tSize; i++)
            {
                for (int j = 0; j < sSize; j++)
                {
                    int sign;
                    if (source[j].Equals(target[i]))
                        sign = 0;
                    else
                        sign = 1;
                    matrix[i + 1, j + 1] = Math.Min(Math.Min(matrix[i, j] + sign, matrix[i + 1, j] + 1), matrix[i, j + 1] + 1);
                }
            }
            return matrix[tSize, sSize];
        }

    }
}
