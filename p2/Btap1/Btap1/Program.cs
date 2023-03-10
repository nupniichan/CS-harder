using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] num = line.Split();
            int m = int.Parse(num[0]);
            int n = int.Parse(num[1]);
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            NhapMang(a, b);
            Sum(a, b);
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
        static void XuatMang(int[,] a, int[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
            }
        }
        static void Sum(int[,] a, int[,] b)
        {
            int rows = a.GetLength(0);
            int columns = a.GetLength(1);
            int[,] ketqua = new int[rows, columns];
            for (int i = 0; i < ketqua.GetLength(0); i++)
            {
                for (int j = 0; j < ketqua.GetLength(1); j++)
                {
                    ketqua[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int i = 0; i < ketqua.GetLength(0); i++)
            {
                for (int j = 0; j <ketqua.GetLength(1); j++)
                {
                    Console.Write(ketqua[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
