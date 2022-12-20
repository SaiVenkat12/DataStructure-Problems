using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class Anagram
    {
        public void anagram()
        {
            string str1 = "heart";
            string str2 = "earth";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (str1.Length == str2.Length)
            {
                if (val1 == val2)
                {
                    Console.WriteLine("Both of the strings are Anagrams");
                }
                else
                {
                    Console.WriteLine("Both of the strings not are Anagrams");
                }
            }
            else 
            {
                Console.WriteLine("length of the String doesn't match, So both strings not are Anagrams");
            }
        }
    }
}
