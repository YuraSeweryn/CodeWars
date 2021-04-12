using System;
using System.Collections.Generic;

namespace Spiral
{
    public class SnailSolution
    {
        public static int[,] Snail(int n)
        {
            int N = n;
            int[,] array = new int[n, n];
            int c = 0, xd = 1, yd = 1, coun = N * N;
            int[,] m = new int[N, N];


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = 0;
                    m[i, j] = array[i, j];
                }
            }
            List<int> answ = new List<int>();
            for (int i = 0; i <= N - 1; i++)
            {
                if (c < coun)
                {
                    for (int j = xd - 1; j <= N - yd; j++)
                    {
                        answ.Add(m[i, j]);
                        c++;
                    }
                }
                yd++;
                if (c < coun)
                {
                    for (int j = yd - 1; j <= N - xd; j++)
                    {
                        answ.Add(m[j, N - i - 1]);
                        c++;
                    }
                }
                xd++;
                if (c < coun)
                {
                    for (int j = N - xd; j >= xd - 2; j--)
                    {
                        answ.Add(m[N - i - 1, j]);
                        c++;
                    }
                }
                if (c < coun)
                {
                    for (int j = N - yd; j >= yd - 1; j--)
                    {
                        answ.Add(m[j, i]);
                        c++;
                    }
                }

            }
            return answ.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
