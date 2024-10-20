using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    internal class Program
    {
        static Dictionary<string, int> records;
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            records = new Dictionary<string, int>();
            for (int i = 0; i < limit; i++)
            {
                Solve();
            }
        }
        static void Solve()
        {
            string input = Console.ReadLine();
            if (records.ContainsKey(input))
            {
                Console.WriteLine(input + records[input]);
                records[input]++;
            }
            else
            {
                records[input] = 1;
                Console.WriteLine("OK");
            }
        }
    }
}
