using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    internal class FindYourNumber
    {
        public static void Display()
        {
            Console.WriteLine("Enter a limit:");
            double limit = Convert.ToInt32(Console.ReadLine());
            double n = Math.Pow(2, limit);
            Console.WriteLine("Enter a guess between 0 and {0}", n - 1);

        }
        public void Question(int firstValue, int lastValue)
        {
            int mid = (firstValue + lastValue) / 2;
            Console.WriteLine("is this  number " + mid + " is grater than your number ?");
            if (Convert.ToChar(Console.ReadLine()) == 0)
            {
                Question(firstValue, lastValue);
            }
            else
            {
                Question(firstValue, mid);
            }
        }
    }
}
