using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class BinarySearching
    {
        public static int Binarysearch(string key)
        {
            string[] Array = { "apple", "mobile", "bike", "mobile", "english" };
            int min = 0, mid = 0, result = 0;
            int max = Array.Length - 1;

            Console.WriteLine("Array values are:");
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine(Array[i]);
            }

            while (min <= max)
            {
                mid = (min + max) / 2;
                int val = Convert.ToInt32(key.CompareTo(Array[mid]));
                if (val == 1)
                    return ++mid;
                Console.WriteLine("Word is present in the array");
                if(val>0)
                    mid= mid + 1;
                else 
                    max= mid - 1;
                
            }
            return -1;

            if (result == -1)
            {
                Console.WriteLine("String is not found");
            }
            else
            {
                Console.WriteLine("String is found");
            }
        }
    }
}
