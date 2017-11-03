using System;

namespace RoateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4] {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 0, 11, 12 },
                { 13, 14, 15, 16 }
            };
            int width = array.GetLength(1);

            //Print initial array
            Console.WriteLine("Initial Array\n");
            int c = 0;
            foreach (int d in array)
            {
                Console.Write($"{d} ");
                c++;
                if (c % width == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            //Rotate the matrix
            int[,] rotated = RotateMatrix(array, 4);

            int[,] RotateMatrix(int[,] matrix, int n)
            {
                int[,] temp = new int[n, n];

                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        temp[i, j] = matrix[n - j - 1, i];
                    }
                }
                return temp;
            }
            //Print rotated matrix
            Console.WriteLine("Rotated array\n");
            int f = 0;
            foreach (int d in rotated)
            {
                Console.Write($"{d} ");
                f++;
                if (f % width == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}
