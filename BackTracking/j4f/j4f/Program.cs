using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace j4f
{
    internal class Program
    {
        // Quay lui
        static int n;
        static int k;
        static int[] x;
        static void Main(string[] args)
        {
            string lines = Console.ReadLine();
            string[] nums = lines.Split();
            n = int.Parse(nums[0]);
            k = int.Parse(nums[1]);
            x = new int[k + 1]; // khong tinh phan tu thu 0 {0,1} <- sai
            Tinh(1);
            Console.ReadKey();
        }
        static void Tinh(int i)
        {
            if (i > k)
            {
                XuatSo();
            }
            else
            {
                for (int j = 1; j <= n; j++)
                {
                    x[i] = j;
                    Tinh(i + 1);
                }
            }
        }
        static void XuatSo()
        {
            for (int i = 1; i <= k; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
