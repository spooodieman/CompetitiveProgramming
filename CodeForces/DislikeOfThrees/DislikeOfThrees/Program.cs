using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DislikeOfThrees
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
            int answer = 0;
            int place = int.Parse(Console.ReadLine());
            for(int i = 1; i <= place; i++)
            {
                answer++;
                while(answer%3 == 0 || answer % 10 == 3)
                {
                    answer++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
