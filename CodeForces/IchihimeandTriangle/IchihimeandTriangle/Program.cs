using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IchihimeandTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for(int i = 0; i < limit; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Console.WriteLine(input[1] + " " + input[2] + " " + input[2]);
            }
        }
    }
}
