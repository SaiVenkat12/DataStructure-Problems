using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class PallindromeNumber
    {
        public void Pallindrome() 
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("The Number {0} is Palindrome", sum);
            else
                Console.Write("The Number {0} is not Palindrome",temp);
        }
    }
}
