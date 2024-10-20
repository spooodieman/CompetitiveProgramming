using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThousandTonsTNT
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
            int size = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> factors = new List<int>();
            for(int i = 1; i <= Math.Sqrt(size); i++)
            {
                if(size%i == 0)
                {
                    factors.Add(i);
                    if (i * i != size) factors.Add(size / i);
                }
            }
            long[] prefixSum = new long[size + 1];
            long current = 0;
            
            for(int i = 1; i <= size; i++)
            {
                current += input[i - 1];
                prefixSum[i] = current;
            }

            long answer = 0;
            for(int i = 0; i < factors.Count; i++)
            {
                long minimum = long.MaxValue;
                long maximum = long.MinValue;

                for(int j = factors[i]; j <= size; j += factors[i])
                {
                    current = prefixSum[j] - prefixSum[j - factors[i]];
                    maximum = Math.Max(maximum, current);
                    minimum = Math.Min(minimum, current);
                }
                answer = Math.Max(answer, maximum - minimum);
            }
            Console.WriteLine(answer);
        }
    }
}
