using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayTooLongWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for(int i = 0; i < limit; i++)
            {
                string word = Console.ReadLine();
                if(word.Length > 10)
                {
                    Console.Write(word[0]);
                    Console.Write(word.Length - 2);
                    Console.Write(word[word.Length - 1]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
