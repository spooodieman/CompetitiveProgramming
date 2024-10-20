using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAtSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int size = input[0];
            int time = input[1];
            char[] inputString = Console.ReadLine().ToCharArray();
            while(time > 0)
            {
                for(int i = 1; i < size; i++)
                {
                    if (inputString[i-1] == 'B' && inputString[i] == 'G')
                    {
                        inputString[i] = 'B';
                        inputString[i - 1] = 'G';
                        i++;
                    }

                }
                time--;
            }
            Console.WriteLine(string.Join("",inputString));
        }    
    }
}
