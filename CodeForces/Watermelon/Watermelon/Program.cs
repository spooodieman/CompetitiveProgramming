using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watermelon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            if(weight % 2 == 0 && weight > 2) 
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
