using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap5
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
            double euclid = Euclid(a, b);
            Console.WriteLine("khoang cach euclid cua 2 ma tran = {0}", euclid);
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
        static double Euclid(int[,] a, int[,] b)
        {
            double TongBinhPhuong = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    double difference = a[i, j] - b[i, j];
                    TongBinhPhuong += Math.Pow(difference, 2);
                }
            }
            return Math.Sqrt(TongBinhPhuong);
        }
    }
}
