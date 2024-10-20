using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeAndPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int i = 0;
            int j = word.Length - 1;
            int number = 0;
            while (i < j)
            {
                if (word[i++] != word[j--]) number++;
            }
            if(number == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
