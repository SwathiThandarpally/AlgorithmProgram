using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class Anagram
    {
        public void Display()
        {
            string str1 = "earth";
            string str2 = "heart";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Word is a Annagram");
            }
            else
            {
                Console.WriteLine("Word is not a Anagram");
            }
        }
    }
}
