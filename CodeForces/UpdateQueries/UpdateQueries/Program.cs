using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++) Solve();
        }
        static void Solve()
        {
            int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] mainString = Console.ReadLine().ToCharArray();
            HashSet<int> iSet = new HashSet<int>();
            int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (int elem in input2) iSet.Add(elem-1);
            List<int> iSetSorted = iSet.ToList();
            iSetSorted.Sort();
            char[] referenceString = Console.ReadLine().ToCharArray();
            Array.Sort(referenceString);
            int ind = 0;
            foreach (int elem in iSetSorted) mainString[elem] = referenceString[ind++];
            if (mainString[0] > mainString[mainString.Length - 1]) Array.Reverse(mainString);
            Console.WriteLine(string.Join("", mainString));
        }
    }
}
