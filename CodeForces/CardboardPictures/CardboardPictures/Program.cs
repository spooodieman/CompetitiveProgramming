using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardboardPictures
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
            ulong[] input1 = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray();
            ulong cardboardArea = input1[1];
            ulong[] areas = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray();

            ulong high = 1000000000, low = 1;
            while(low <= high)
            {
                ulong mid = low + (high - low) / 2;
                ulong tarsum = 0;
                for(int i = 0; i < areas.Length; i++)
                {
                    tarsum += (areas[i] + 2 * mid) * (areas[i] + 2 * mid);
                    if (tarsum > cardboardArea) break;
                        
                }
                if (tarsum == cardboardArea)
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if (tarsum < cardboardArea) low = mid + 1;
                else high = mid;
            }
        }
    }
}
