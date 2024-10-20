using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
            if(n == 0 || m == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int a = int.Parse(input[2]);
            n = (n / a) + Convert.ToInt32(n % a != 0);
            m = (m / a) + Convert.ToInt32(m % a != 0);
            Console.WriteLine((long)(m * n));
        }
    }
}
