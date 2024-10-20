using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PetyaAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            int s1Sum = 0;
            int s2Sum = 0;
            for(int i = 0; i < string1.Length; i++)
            {
                s1Sum += returnValue(string1[i]);
                s2Sum += returnValue(string2[i]);
            }
            /*if (s1Sum > s2Sum) Console.WriteLine(1);
            else if (s1Sum < s2Sum) Console.WriteLine(-1);
            else Console.WriteLine(0);*/
            Console.WriteLine(s1Sum + " " + s2Sum);
        }
        static int returnValue(char letter)
        {
            if (letter >= 'A' && letter <= 'Z') return (letter - 'A' + 1);
            return (letter - 'a' + 1);
        }
    }
}
