using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준._004단계
{
    internal class _1차원배열001
    {
        static void Main1(string[] args)
        {
            string A = Console.ReadLine();
            int a = int.Parse(A);
            string[] B = Console.ReadLine().Split();
            int[] b = Array.ConvertAll(B, int.Parse);

            for (int i = 0; i < b.Length-1; i++)
            {
                for (int j = i + 1; j < a; j++)
                {
                    if (b[i] > b[j])
                    {
                        int trim = b[j];
                        b[j] = b[i];
                        b[i] = trim;
                    }
                }

            }
            Console.WriteLine(b[0] + " " + b[b.Length-1]);
        }
    }
}
