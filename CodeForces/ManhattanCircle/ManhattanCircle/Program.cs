using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManhattanCircle
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
            string[] input = Console.ReadLine().Split(' ');
            int rows = int.Parse(input[0]);
            int columns = int.Parse(input[1]);
            List<string> indices = new List<string>();
            char[][] matrix = new char[rows][];
            for(int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (matrix[i][j] == '#')
                    {
                        indices.Add((i + 1) + " " +(j + 1));
                    }
                }
            }
            int index = (indices.Count/2);
            Console.WriteLine(indices[index]);
        }
    }
}
