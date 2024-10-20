using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
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
            int size = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            foreach (int num in array) sum += num;
            if(sum%2 == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int answer = int.MaxValue;
            for(int i = 0; i < size; i++)
            {
                int temp = 0;
                while (array[i] %2 == (array[i] / 2) % 2)
                {
                    temp++;
                    array[i] /= 2;
                }
                answer = Math.Min(answer,temp+1);
            }
            Console.WriteLine(answer);
        }
    }
}
