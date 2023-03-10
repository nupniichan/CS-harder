using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Btap6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[,] a = new int[x,x];
            int[,] b = new int[x,x];
            NhapMang(a, b);
            int sum = DotProduct(a, b);
            Console.WriteLine(sum);
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
        static int DotProduct(int[,]a, int[,]b)
        {
            int sum = 0;
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int temp = a[i,j] * b[i,j];
                    sum += temp;
                }
            }
            return sum;
        }
    }
}
