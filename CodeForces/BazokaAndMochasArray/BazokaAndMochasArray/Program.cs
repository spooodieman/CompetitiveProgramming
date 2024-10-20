using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BazokaAndMochasArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++) Solve();
        }
        static void Solve()
        {
            string input1 = Console.ReadLine();
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for(int i = 0; i <array.Length; i++)
            {
                bool is_sorted = true;
                int last = -1000000;
                for(int j = i; j < i + array.Length; j++)
                {
                    if (array[j%array.Length] < last)
                    {
                        is_sorted = false;
                        break;
                    }
                    last = array[j%array.Length];
                }
                if (is_sorted)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
