using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    public class primenum
    {
       public void primenumber()
        {
            bool isPrime = true;
            int i, j;
            Console.WriteLine("Prime Numbers between 1 to 1000 are ");
            for (i = 2; i <= 1000; i++)
            {
                for (j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(" " + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
