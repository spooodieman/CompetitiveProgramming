using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rudolf_and_121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                Solve();
            }
        }
        static void Solve()
        {
            int[] arr = new int[int.Parse(Console.ReadLine())];
            string[] elements = Console.ReadLine().Split(' ');
            for (int j = 0; j < elements.Length; j++)
            {
                arr[j] = int.Parse(elements[j]);
            }
            for (int j = 1; j < arr.Length - 1; j++)
            {
                if (arr[j] == 0) continue;

                if (arr[j - 1] * 2 > arr[j])
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    arr[j] -= (2 * arr[j - 1]);
                    arr[j + 1] -= arr[j - 1];
                    arr[j - 1] = 0;
                }
            }
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
