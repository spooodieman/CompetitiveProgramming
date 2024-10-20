using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int oneCount = 0;
            int zeroCount = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1')
                {
                    oneCount++;
                    zeroCount = 0;
                }
                else
                {
                    oneCount = 0;
                    zeroCount++;
                }
                if(oneCount == 7 || zeroCount == 7)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
