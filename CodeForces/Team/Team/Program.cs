using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int limit = int.Parse(Console.ReadLine());
            for(int i = 0; i < limit; i++)
            {
                int current = 0;
                string input = Console.ReadLine();
                for(int j = 0; j < 5; j++)
                {
                    if (input[j] == '1') current++;
                }
                if (current >= 2) answer++;
            }
            Console.WriteLine(answer);
        }
    }
}
