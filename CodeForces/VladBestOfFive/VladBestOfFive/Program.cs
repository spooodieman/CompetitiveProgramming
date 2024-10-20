using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VladBestOfFive
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
            string input = Console.ReadLine();
            int aCount = 0;
            int bCount = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A')
                {
                    aCount++;
                }
                else
                {
                    bCount++;
                }
                if(aCount == 3)
                {
                    Console.WriteLine("A");
                    return;
                }
                else if(bCount == 3)
                {
                    Console.WriteLine("B");
                    return;
                }
            }
        }
    }
}
