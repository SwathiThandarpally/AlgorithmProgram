using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class ExtendedPrimeNumber
    {
        public void Display()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the prime Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }
        public bool Anagrams(string value1, string value2)
        {
            if (value1 is null) throw new ArgumentNullException(nameof(value1));
            if (value2 is null) throw new ArgumentNullException(nameof(value2));

            if (value1.Length != value2.Length)
            {
                return false;
            }
            var content1 = value1.ToCharArray();
            Array.Sort(content1);
            var content2 = value2.ToCharArray();
            Array.Sort(content2);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            for(int i = 0; i < content2.Length; i++)
            {
                if(content1[i] == content2[i])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            return false
           
        }
    }
}
