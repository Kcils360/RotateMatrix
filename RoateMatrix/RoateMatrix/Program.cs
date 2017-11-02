using System;

namespace RoateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4] {
                { 1,2,3,4 },
                { 5,6,7,8 },
                { 9,0,11,12 },
                { 13,14,15,16 }
            };

            int[,] rotated = RotateMatrix(array, 4);

            int[,] RotateMatrix(int[,] matrix, int n)
            {
                int[,] ret = new int[n, n];

                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        ret[i, j] = matrix[n - j - 1, i];
                    }
                }
                return ret;
            }

        }
    }
}
