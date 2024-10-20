using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequiredRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for(int i = 0;i < limit; i++)
            {
                Solve();
            }
        }
        static void Solve()
        {
            string[] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int k = int.Parse(input[2]);
            int a = k % x;
            if(a - y >= 0)
            {
                k = k - (a - y);
            }
            else
            {
                k = k - a - x + y;
            }
            Console.WriteLine(k);
        }
    }
}
