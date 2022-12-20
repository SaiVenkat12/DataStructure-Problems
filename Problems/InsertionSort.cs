using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class InsertionSort
    {
        public void Insertion() 
        {
            int[] arr = new int[7] { 99, 589, 76, 38, 18,44,12 };
            int n = 7;
            int i, j, val;
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("Unsorted array : ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                for (j = i - 1; j >= 0;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
