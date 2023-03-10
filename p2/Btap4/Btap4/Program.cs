using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btap4
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
            NhapMang(a);
            ChuyenVi(a);
            int[,] transposedMatrix = ChuyenVi(a);
            XuatMang(transposedMatrix);
            Console.ReadKey();
        }
        static void NhapMang(int[,] a)
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
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] ChuyenVi(int[,] a)
        {
            int rows = a.GetLength(0);
            int columns = a.GetLength(1);
            int[,] result = new int[columns, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[j, i] = a[i, j];
                }
            }

            return result;
        }
    }
}
