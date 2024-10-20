using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairPeakNeither
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
            string[] nums = Console.ReadLine().Split(' ');
            int[] intnum = new int[3];
            for(int i = 0; i < nums.Length; i++)
            {
                intnum[i] = int.Parse(nums[i]);
            }
            if (intnum[1] > intnum[0] && intnum[2] > intnum[1])
            {
                Console.WriteLine("STAIR");
                return;
            }
            else if (intnum[1] > intnum[0] && intnum[1] > intnum[2])
            {
                Console.WriteLine("PEAK");
                return;
            }
            Console.WriteLine("NONE");
        }
    }
}
