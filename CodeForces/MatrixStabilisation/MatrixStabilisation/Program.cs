using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixStabilisation
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
            string[] size = Console.ReadLine().Split(' ');
            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);
            int[][] matrix = new int[rows][];
            for(int i = 0; i < rows; i++)
            {
                matrix[i] = new int[columns];
                string[] input = Console.ReadLine().Split(' ');
                for(int j = 0; j < columns; j++)
                {
                    matrix[i][j] = int.Parse(input[j]);
                }
            }
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    int max = 0;
                    if (i != 0) max = Math.Max(max, matrix[i - 1][j]);
                    if (j != 0) max = Math.Max(max, matrix[i][j-1]);
                    if (i != rows - 1) max = Math.Max(max, matrix[i+1][j]);
                    if (j != columns - 1) max = Math.Max(max, matrix[i][j+1]);
                    matrix[i][j] = Math.Min(matrix[i][j], max);
                }
            }
            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
