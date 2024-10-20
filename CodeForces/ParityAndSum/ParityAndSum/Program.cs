using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParityAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for(int i = 0; i < limit; i++)
            {
                Solve();
            }
        }
        static void Solve()
        {
            List<int> odd = new List<int>();
            int size = int.Parse(Console.ReadLine());
            List<int> even = new List<int>();
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < size; i++)
            {
                int current = int.Parse(input[i]);
                if(current % 2 == 0)
                {
                    even.Add(current);
                }
                else
                {
                    odd.Add(current);
                }
            }
            if(odd.Count == 0 || even.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            odd.Sort();
            even.Sort();
            long max = odd[odd.Count - 1];
            int answer = 0;
            for(int i = 0; i < even.Count; i++)
            {
                if(max < even[i])
                {
                    answer += 2;
                    max = (even[i] * 2) + max;
                }
                else
                {
                    answer++;
                    max = even[i] + max;
                }
            }
            int ans1 = 0;
            even.Reverse();
            max = odd[odd.Count - 1];
            for (int i = 0; i < even.Count; i++)
            {
                if(max < even[i])
                {
                    ans1 += 2;
                    max = (even[i] * 2) + max;
                }
                else
                {
                    ans1++;
                    max = even[i] + max;
                }
            }
            Console.WriteLine(Math.Min(ans1,answer));
        }
    }
}
