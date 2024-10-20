using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sclae
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
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int size = input[0];
            int factor = input[1];
            string[] matrix = new string[size];
            for(int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine();
            }
            for(int i = 0; i < size; i+= factor)
            {
                for(int j = 0; j < size; j += factor)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
