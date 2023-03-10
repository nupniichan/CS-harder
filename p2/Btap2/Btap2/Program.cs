using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Btap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] num = line.Split();
            int m = int.Parse(num[0]);
            int n = int.Parse(num[1]);
            int p = int.Parse(num[2]);
            int[,] a = new int[m, n];
            int[,] b = new int[n, p];
            NhapMang(a, b);
            int[,] sum = DotProduct(a, b);
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void NhapMang(int[,] a, int[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                string lines = Console.ReadLine();
                string[] nums = lines.Split();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(nums[j]);
                }
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                string lines = Console.ReadLine();
                string[] nums = lines.Split();
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = int.Parse(nums[j]);
                }
            }
        }
        static int[,] DotProduct(int[,] a, int[,] b)
        {
            int rowsA = a.GetLength(0);
            int colsA = a.GetLength(1);
            int colsB = b.GetLength(1);
            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int dotProduct = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        dotProduct += a[i, k] * b[k, j];
                    }
                    result[i, j] = dotProduct;
                }
            }

            return result;
        }
    }
}
