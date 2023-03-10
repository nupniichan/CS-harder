using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 80, 30, 90, 40, 50, 70 };
            Console.WriteLine("Original array:");
            PrintArray(arr);

            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted array:");
            PrintArray(arr);

            Console.ReadKey();
        }
        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int pivotindex = Partition(a, left, right);
                QuickSort(a, left, pivotindex);
                QuickSort(a, pivotindex + 1, right);
            }
        }
        private static int Partition(int[] a, int left, int right)
        {
            int pivot = a[(left + right) / 2];
            int i = left - 1;
            int j = right + 1;
            while (true)
            {
                do
                {
                    i++;
                } while (a[i] < pivot);
                do
                {
                    j--;
                } while (a[j] > pivot);
                if (i >= j)
                {
                    return j;
                }
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
