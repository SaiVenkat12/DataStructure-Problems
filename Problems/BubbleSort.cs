using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class BubbleSort
    {
        public void Bubble()
        {
            int[] arr = { 24, 0, -7, 1, 987, 53 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble Sort : ");
            foreach (int b in arr)
            {
                Console.Write(b + " ");
            }
        }
    }
}
