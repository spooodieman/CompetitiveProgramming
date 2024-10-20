using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryTask
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
            if(input.Length <= 2)
            {
                Console.WriteLine("NO");
                return;
            }
            if(input.Substring(0,2) == "10")
            {
                if (input[2] == '0' || (input[2] == '1' && input.Length == 3))
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
