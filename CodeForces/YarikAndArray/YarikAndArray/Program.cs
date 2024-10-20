using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YarikAndArray
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
            int[] array = new int[int.Parse(Console.ReadLine())];
            string[] input = Console.ReadLine().Split(' ');
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            int current = array[0];
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if ((Math.Abs(array[i]) % 2 == 0 && Math.Abs(array[i - 1]) % 2 == 0) || (Math.Abs(array[i]) % 2 == 1 && Math.Abs(array[i - 1]) % 2 == 1))
                {
                    current = array[i];
                }
                else
                {
                    current += array[i];
                }
                if(current < array[i])
                {
                    current = array[i];
                }
                max = Math.Max(current, max);
                    
            }
            Console.WriteLine(max);
        }
    }
}
